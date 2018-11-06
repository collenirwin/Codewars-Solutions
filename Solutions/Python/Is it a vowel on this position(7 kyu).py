def check_vowel(string, position):
    return string.lower()[position] in "aeiou" if position > -1 and position < len(string) else False