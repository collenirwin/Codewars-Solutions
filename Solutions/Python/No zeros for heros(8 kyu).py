def no_boring_zeros(n):
    return int(str(n).strip("0")) if n != 0 else n