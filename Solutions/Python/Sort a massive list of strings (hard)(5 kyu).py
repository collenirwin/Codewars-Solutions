from heapq import merge

def sort(words):
    words = list(words)
    length = len(words)
    if length < 2:
        return words
    
    middle = length // 2
    left = words[:middle]
    right = words[middle:]

    left = sort(left)
    right = sort(right)

    return iter(list(merge(left, right)))