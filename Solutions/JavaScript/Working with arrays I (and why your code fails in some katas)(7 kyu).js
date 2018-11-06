function withoutLast(arr) {
  const a = [].concat(arr);
  a.pop();
  return a;
}