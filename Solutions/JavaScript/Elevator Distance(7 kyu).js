function elevatorDistance(array) {
  let floors = 0;

  for (let x = 1; x < array.length; x++) {
    floors += Math.max(array[x], array[x - 1]) - Math.min(array[x], array[x - 1]);
  }
  
  return floors;
}