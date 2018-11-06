const isPrime = (number) => {
  for (let x = 2, sqrt = Math.sqrt(number); x <= sqrt; x++) {
    if (number % x === 0) {
      return false;
    }
  }
  
  return number > 1;
};

function total(arr) {
  return arr && arr.length !== 0
    ? arr.reduce((t, x, i) => isPrime(i) ? t + x : t, 0)
    : 0;
}