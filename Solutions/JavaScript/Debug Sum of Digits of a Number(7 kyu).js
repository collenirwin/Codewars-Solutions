function getSumOfDigits(integer) {
  return integer.toString().split("").reduce((t, x) => t + parseInt(x), 0);
}