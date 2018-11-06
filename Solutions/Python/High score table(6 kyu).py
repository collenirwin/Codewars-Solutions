class HighScoreTable:
    
    def __init__(self, max):
        self.max = max
        self.scores = []
    
    def update(self, score):
        self.scores.append(score)
        self.scores.sort()
        self.scores.reverse()
        if len(self.scores) > self.max:
            self.scores.pop()
        
    
    def reset(self):
        self.scores.clear()