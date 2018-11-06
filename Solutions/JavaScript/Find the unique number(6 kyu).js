function findUniq(arr) {
  if (arr.filter(x => x === arr[0]).length === 1) {
    return arr[0];
  }
  
  return arr.filter(x => x !== arr[0])[0];
}