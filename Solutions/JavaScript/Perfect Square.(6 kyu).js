function perfectSquare(string) {
  const array = string.split("\n");
  
  for (let row of array) {
    if (row.length !== array[0].length || !/^\.+$/.test(row)) {
      return false;
    }
  }
  
  return array.length === array[0].length;
}