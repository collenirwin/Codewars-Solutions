function splitByValue(k, elements) {
  const lt = [];
  const gt = [];
  
  for (let x = 0; x < elements.length; x++) {
    if (elements[x] < k) {
      lt.push(elements[x]);
    }
    else {
      gt.push(elements[x]);
    }
  }
  
  return lt.concat(gt);
}