const omnibool = {
  value: 1,
  toString: function() {
    return Math.abs(this.value--);
  }
};