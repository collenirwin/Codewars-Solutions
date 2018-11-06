Array.prototype.flatMap = function(f) {
  return this.reduce((t, x, i) => t.concat(f(x, i)), []);
};