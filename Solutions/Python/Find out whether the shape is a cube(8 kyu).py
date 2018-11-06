def cube_checker(volume, side):
    return volume > 0 and volume == side ** 3
11 months agoRefactor
def cube_checker(volume, side):
    return volume == side ** 3 if volume > 0 and side > 0 else False