def find_children(santas_list, children):
    lst = []
    for child in children:
        if child in santas_list and not child in lst:
            lst.append(child)
    return sorted(lst)