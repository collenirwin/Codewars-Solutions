def find_page_number(pages):
    bad_pages = []
    count = 1
    
    for page in pages:
        if page != count:
            bad_pages.append(page)
        else:
            count += 1
            
    return bad_pages