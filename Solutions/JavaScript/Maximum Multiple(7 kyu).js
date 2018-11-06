function maxMultiple(divisor, bound) {
  for (let x = bound; x > 0; x--) {
    if (x % divisor === 0) {
      return x;
    }
  }
  
  return 0;
}