special = [ "*", "#" ]

buttons = [
    " 0",
    "1",
    "ABC2",
    "DEF3",
    "GHI4",
    "JKL5",
    "MNO6",
    "PQRS7",
    "TUV8",
    "WXYZ9"
]

def sequence(phrase):
    output = ""
    last_index = -1
    
    for letter in phrase.upper():
        index = 0
        
        for button in buttons:
            if letter in special:
                output += letter
                last_index = -1
                break
            if letter in button:
                if index == last_index:
                    output += "p"
                    
                last_index = index
                output += str(index) * (button.index(letter) + 1)
                break
                
            index += 1
            
    return output
            