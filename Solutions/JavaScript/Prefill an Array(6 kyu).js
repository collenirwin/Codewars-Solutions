function prefill(n, v) {
  if (n != parseInt(n) || n < 0) {
    throw new TypeError(`${n} is invalid`);
  }
  
  if (n == 0) {
    return [];
  }

  return new Array(n).fill(v);
}