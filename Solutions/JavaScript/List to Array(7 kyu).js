function listToArray(list) {
  const array = [list.value];
  
  while (list = list.next) {
    array.push(list.value);
  }
  
  return array;
}