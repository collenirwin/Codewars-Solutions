function sum() {
  return [...arguments].reduce((t, x) => t + x);
}