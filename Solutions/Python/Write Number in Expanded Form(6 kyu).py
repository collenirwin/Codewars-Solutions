def expanded_form(num):
    n = str(num)
    out = []
    
    for x in range(len(n)):
        if n[x] != "0":
            out.append(n[x] + "0" * (len(n) - x - 1))
        
    return " + ".join(out)
    