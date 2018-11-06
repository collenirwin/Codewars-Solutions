class Student:
    def __init__(self, first_name, last_name, grades = None):
        self.first_name = first_name
        self.last_name = last_name
        self.grades = grades if grades != None else []
    
    def add_grade(self, grade):
        self.grades.append(grade)
    
    def get_average(self):
        return sum(self.grades) / len(self.grades)