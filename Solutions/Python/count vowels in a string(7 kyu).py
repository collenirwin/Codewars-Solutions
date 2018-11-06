from functools import reduce

def count_vowels(s = ''):
    if str(s) != s:
        return None
    
    count = 0
    for x in s.lower():
        count += int(x in "aeiou")
    
    return count
    