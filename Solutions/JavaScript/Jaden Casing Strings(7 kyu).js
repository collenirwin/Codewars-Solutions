String.prototype.toJadenCase = function () {
  return this
    .split(" ")
    .map(x => x.substring(0, 1).toUpperCase() + x.substring(1))
    .join(" ");
};