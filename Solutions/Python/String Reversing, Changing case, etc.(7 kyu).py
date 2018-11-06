def invert_case(word):
    return "".join(x.lower() if x.isupper() else x.upper() for x in word)

def reverse_and_mirror(s1, s2):
    s1 = invert_case(s1)
    return invert_case(s2[::-1]) + "@@@" + s1[::-1] + s1