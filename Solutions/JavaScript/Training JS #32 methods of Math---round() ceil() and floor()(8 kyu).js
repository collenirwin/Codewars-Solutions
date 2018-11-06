function roundIt(n) {
  const div = n.toString().split(".");
  
  if (div[0].length < div[1].length) {
    return Math.ceil(n);
  }
  
  if (div[0].length > div[1].length) {
    return Math.floor(n);
  }
  
  return Math.round(n);
}