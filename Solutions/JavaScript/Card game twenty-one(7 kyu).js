function twentyOne(card1, card2, card3) {
  let sum = 0;
  for (let x = 0; x < arguments.length; x++) {
    const value = arguments[x].slice(0, arguments[x].length - 1);
    
    if (value === "J") {
      sum += 2;
    }
    else if (value === "Q") {
      sum += 3;
    }
    else if (value === "K") {
      sum += 4;
    }
    else if (value === "A") {
      sum += 11;
    }
    else {
      sum += parseInt(value);
    }
  }
  
  return sum === 21 
    ? "twenty-one" 
    : sum > 21 
      ? "more" 
      : "less";
}