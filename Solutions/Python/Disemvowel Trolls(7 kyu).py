import re

def disemvowel(string):
    return re.sub("[aeiou]", "", string, flags=re.IGNORECASE)