function squareDigits(num) {
  return parseInt(num.toString().split("").map(x => Math.pow(x, 2)).join(""));
}