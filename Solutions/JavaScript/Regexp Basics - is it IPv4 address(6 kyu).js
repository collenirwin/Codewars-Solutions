String.prototype.ipv4Address = function() {
  const octets = this.split(".");
  return octets.length === 4 && 
    octets.every(x => 
      x.length > 0 && x === x.trim() && x < 256 && x > -1 && x.length === parseInt(x).toString().length);
};