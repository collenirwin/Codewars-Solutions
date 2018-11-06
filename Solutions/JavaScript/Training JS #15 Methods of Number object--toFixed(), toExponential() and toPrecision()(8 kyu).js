function howManySmaller(arr, n) {
  return arr.map(x => x.toFixed(2)).reduce((t, x) => t + (x < n), 0);
}