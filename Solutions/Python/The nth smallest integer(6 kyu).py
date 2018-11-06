def nth_smallest(arr, n):
    distinct = sorted(set(arr))
    
    if n > len(distinct):
        return None
    
    return distinct[n - 1]