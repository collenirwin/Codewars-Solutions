from random import randrange

def random_case(s):
    return "".join([x.lower() if randrange(2) == 1 else x.upper() for x in s])