function solve(s) {
  const alpha = " abcdefghijklmnopqrstuvwxyz";
  return s
    .replace(/a|e|i|o|u/g, "_")
    .split("_")
    .map(x => x.split("").reduce((t, y) => t + alpha.indexOf(y), 0))
    .sort((x, y) => x - y)
    .pop();
}