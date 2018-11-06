def check_digit(number, index1, index2, digit):
    if index1 > index2:
        index1, index2 = index2, index1
    return str(digit) in str(number)[index1:index2 + 1]