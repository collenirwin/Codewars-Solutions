Array.range = function(start, count) {
  return Array.from(Array(count).keys()).map((x, i) => start + i);
};

Array.prototype.sum = function() {
  return this && this.length > 0 ? this.reduce((t, x) => t + x, 0) : 0;
};