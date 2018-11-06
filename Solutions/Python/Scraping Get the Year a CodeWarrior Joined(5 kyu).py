from urllib.request import urlopen
import re

def get_member_since(username):
    url = "https://www.codewars.com/users/" + username
    
    html = ""
    with urlopen(url) as profile:
        html = profile.read().decode('utf-8')
        
    return re.search("(?:Since:<\/b>)(\w{3}\s\d{4})", html).group(1)