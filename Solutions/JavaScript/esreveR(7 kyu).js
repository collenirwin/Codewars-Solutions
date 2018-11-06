reverse = function(array) {
  const reversed = [];
  
  for (let x = array.length - 1; x > -1; x--) {
    reversed.push(array[x]);
  }
  
  return reversed;
};