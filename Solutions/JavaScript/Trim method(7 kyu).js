String.prototype.trim = function(c) {
  c = c || " ";
  const r1 = new RegExp(`^${c}+`, "gi");
  const r2 = new RegExp(`${c}+$`, "gi");
  return this.replace(r1, "").replace(r2, "");
};