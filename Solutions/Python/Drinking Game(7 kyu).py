def game(a, b):
    if a < 1 or b < 1:
        return "Non-drinkers can't play"
    
    drinks = 1
    mike = 0
    joe = 0
    while True:
        if drinks % 2 == 0:
            joe += drinks
        else:
            mike += drinks
            
        if mike > a:
            return "Joe"
        if joe > b:
            return "Mike"
            
        drinks += 1
    