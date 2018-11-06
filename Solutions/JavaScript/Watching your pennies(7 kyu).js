function manageMoney(cash, expenses, rate) {
  rate = rate * 0.01;
  
  for (let x = 0; x < 12; x++) {
    cash += cash * rate - expenses;
    
    if (cash <= 0) {
      return `You ran out of money after ${x} months`;
    }
  }
  
  return "You still have $" + cash.toFixed(2);
}