def conjugate(verb):
    con = {
        "a": ["o", "as", "a", "amos", "ais", "an"],
        "e": ["o", "es", "e", "emos", "eis", "en"],
        "i": ["o", "es", "e", "imos", "is", "en"]
    }
    
    return { verb: [verb[:-2] + x for x in con[verb[-2]]] }