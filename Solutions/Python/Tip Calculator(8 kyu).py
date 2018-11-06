from math import ceil

def calculate_tip(amount, rating):
    rating=rating.lower()

    if rating == "terrible":
        return 0
        
    if rating == "poor":
        return ceil(amount*0.05)
    
    if rating == "good":
        return ceil(amount*0.10)
        
    if rating == "great":
        return ceil(amount*0.15)
        
    if rating == "excellent":
        return ceil(amount*0.20)
        
    return"Rating not recognised"
        
        
    