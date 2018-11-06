function deleteValues(array, pred) {
  let _array = array.filter(x => !pred(x));
  
  // hack
  array.length = 0;
  for (var i = 0; i < _array.length; i++) {
    array.push(_array[i]);
  }
  return array;
}