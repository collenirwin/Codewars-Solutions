function removeNthElement(arr, n) {
  // Fix it
  var arrCopy = [].concat(arr);
  arrCopy.splice(n, 1); // removes the nth element
  return arrCopy;
}