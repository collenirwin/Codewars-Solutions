function last(x) {
  return x.split(" ").sort((x, y) => x.slice(-1) > y.slice(-1) ? 1 : -1);
}