def vert_mirror(strng):
    return "".join(map(lambda x: x[::-1] + "\n", strng.split("\n"))).strip("\n")
        
def hor_mirror(strng):
    return "".join(map(lambda x: x + "\n", strng.split("\n")[::-1])).strip("\n")
    
def oper(fct, s):
    return fct(s)