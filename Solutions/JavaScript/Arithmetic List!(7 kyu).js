var seqlist = function(first, c, l) {
  const array = [first];
  
  for (let x = 1; x < l; x++) {
    array.push(array[x - 1] + c);
  }
  
  return array;
};