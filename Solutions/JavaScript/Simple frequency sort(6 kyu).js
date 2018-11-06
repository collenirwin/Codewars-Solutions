function solve(arr) {
  const count = arr.reduce((t, x) => {
    t[x] = isNaN(t[x]) ? 0 : t[x] + 1;
    return t;
  }, {});
  
  return arr.sort((x, y) => {
    const diff = count[y] - count[x];
    return diff === 0 ? x - y : diff;
  });
}