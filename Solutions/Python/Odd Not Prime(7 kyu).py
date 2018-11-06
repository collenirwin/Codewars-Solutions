import math

def is_prime(n):
    if n < 2:
        return False
    
    for x in range(3, int(math.sqrt(n)) + 1, 2):
        if n % x == 0:
            return False
            
    return True

def odd_not_prime(n):
    if n < 1:
        return 0

    count = 1
    
    for x in range(9, n + 1, 2):
        if not is_prime(x):
            print(x)
            count += 1
    
    return count