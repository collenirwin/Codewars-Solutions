// optimize
function findX(n) {
  let x = 0;
  const n2 = n * 2;
  
  for (let i = 0; i < n; i++) {
    x += i + (n2 * (n2 - 1) / 2) + (n2 - 1) * i;
  }
  
  return x;
}