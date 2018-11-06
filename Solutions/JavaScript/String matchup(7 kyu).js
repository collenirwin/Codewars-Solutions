function solve(a, b) {
  const array = new Array(b.length).fill(0);
  
  for (let x of a) {
    for (let y = 0; y < b.length; y++) {
      if (x === b[y]) {
        array[y]++;
      }
    }
  }
  
  return array;
}