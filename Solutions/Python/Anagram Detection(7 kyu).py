# write the function is_anagram
def is_anagram(test, original):
    return len(test) == len(original) and set(test.lower()) == set(original.lower())