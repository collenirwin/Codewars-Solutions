def find_similar_dogs(breed):
    temperment = dogs[breed]
    good_boys = set()
    most_common = 0
    
    for dog in dogs:
        if dog == breed:
            continue
            
        common = 0
        for x in temperment:
            if x in dogs[dog]:
                common += 1
        
        if common > most_common:
            good_boys = {dog}
            most_common = common
        elif common == most_common:
            good_boys.add(dog)
            
    return good_boys