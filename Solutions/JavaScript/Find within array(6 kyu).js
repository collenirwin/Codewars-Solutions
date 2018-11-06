var findInArray = function(array, iterator) {
  for (let x = 0; x < array.length; x++) {
    if (iterator(array[x], x)) {
      return x;
    }
  }
  
  return -1;
};