function howManyGifts(maxBudget, gifts) {
  const g = [].concat(gifts).sort((x, y) => x - y);
  
  let max = g.reduce((t, x) => t + x, 0);
  while (max > maxBudget)
  {
    max -= g.pop();
  }
  
  return g.length;
}