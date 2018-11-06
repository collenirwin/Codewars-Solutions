def accum(s):
    out = ""
    for x in range(len(s)):
        out += s[x].upper() + (s[x].lower() * x) + "-"
    return out[:-1]