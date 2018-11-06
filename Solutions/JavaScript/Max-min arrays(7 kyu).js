function solve(arr) {
  arr.sort((a, b) => a - b);
  
  const mid = arr.length / 2;
  const min = arr.slice(0, mid);
  const max = arr.slice(mid).reverse();
  
  const result = [];
  
  for (let x = 0; x < max.length; x++) {
    result.push(max[x]);
    if (min[x] != undefined) {
      result.push(min[x]);
    }
  }
  
  return result;
}