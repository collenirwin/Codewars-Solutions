from datetime import datetime

def increment_loop(n):
    start = datetime.now()
    i = 0
    while True:
        if (datetime.now() - start).total_seconds() >= n:
            return i
        i += 1
    