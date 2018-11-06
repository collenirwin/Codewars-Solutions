def reverse_fun(n):
    n = n[::-1]
    for x in range(len(n)):
        n = n[:x + 1] + (n[x + 1:])[::-1]
    return n