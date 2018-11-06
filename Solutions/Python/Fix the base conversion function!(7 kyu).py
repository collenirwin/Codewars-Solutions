#fix the function below!

def convert_num(number, base):
    try:
        if base == "hex":
            return "0x{0:x}".format(number)
        if base == "bin":
            return "0b{0:b}".format(number)
    except:
        return "Invalid number input"
    return "Invalid base input"