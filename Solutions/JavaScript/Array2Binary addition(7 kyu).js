function arr2bin(arr) {
  return arr && arr.length != 0
    ? arr.every(x => typeof x === "number") 
      ? arr.reduce((t, x) => t + x, 0).toString(2)
      : false
    : "0";
}