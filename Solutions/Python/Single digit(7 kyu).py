from functools import reduce

def single_digit(n):
    if n < 10:
        return n
    
    n_bin = map(int, bin(n)[2:])
    return single_digit(reduce(lambda t, x: t + x, n_bin))