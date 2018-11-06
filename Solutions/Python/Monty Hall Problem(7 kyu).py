def monty_hall(correct_door, guesses):
    correct_guesses = 0
    
    for guess in guesses:
        if guess != correct_door:
            correct_guesses += 1
            
    return round(100.0 * (correct_guesses / len(guesses)))
            