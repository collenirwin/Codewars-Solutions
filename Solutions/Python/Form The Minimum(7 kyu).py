def min_value(digits):
    return int("".join(sorted(set("".join(map(str, digits))))))