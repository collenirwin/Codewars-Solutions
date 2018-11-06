import sqlite3

movies = [
    ["Rise of the Planet of the Apes", 2011, 77],
    ["Dawn of the Planet of the Apes", 2014, 91],
    ["Alien", 1979, 97],
    ["Aliens", 1986, 98],
    ["Mad Max", 1979, 95],
    ["Mad Max 2: The Road Warrior", 1981, 100]
]

conn = sqlite3.connect('/tmp/movies.db')
cursor = conn.cursor()

cursor.execute('''CREATE TABLE MOVIES
    (Name text, Year number, Rating number)''')

sql = "INSERT INTO MOVIES VALUES ('%s','%d','%d')"

for movie in movies:
    cursor.execute(sql % (movie[0], movie[1], movie[2]))

conn.commit()
conn.close()