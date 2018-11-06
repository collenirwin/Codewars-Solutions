def test(r):
    avg = round(sum(r) / len(r), 3)
    
    hal = { "h": 0, "a": 0, "l": 0 }
    
    for mark in r:
        if mark > 8:
            hal["h"] += 1
        elif mark > 6:
            hal["a"] += 1
        else:
            hal["l"] += 1
    
    return [avg, hal, "They did well"] if hal["h"] == len(r) else [avg, hal]
    