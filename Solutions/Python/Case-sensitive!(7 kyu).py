def case_sensitive(s):
    not_lower = [x for x in s if x != x.lower()]
    return [len(not_lower) == 0, not_lower]