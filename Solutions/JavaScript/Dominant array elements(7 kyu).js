function solve(arr) {
  return arr
    .filter((x, i) => arr
      .slice(i).filter(y => x > y).length === arr.length - i - 1);
}