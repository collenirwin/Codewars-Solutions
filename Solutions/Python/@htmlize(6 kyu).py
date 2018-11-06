from functools import wraps

def htmlize(tag):
    def decorator(func):
        @wraps(func)
        def wrapper(text):
            return "<{0}>{1}</{0}>".format(tag, func(text))
        return wrapper
    return decorator