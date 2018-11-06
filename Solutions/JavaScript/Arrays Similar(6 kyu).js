function arraysSimilar(arr1, arr2) {
  const a1 = [].concat(arr1).sort();
  const a2 = [].concat(arr2).sort();
  
  for (let x = 0; x < a1.length; x++) {
    if (a1[x] !== a2[x]) {
      return false;
    }
  }
  
  return a1.length === a2.length;
}