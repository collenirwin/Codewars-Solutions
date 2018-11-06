function menFromBoys(arr) {
  const men = new Set();
  const boys = new Set();
  
  for (let male of arr) {
    const maleSet = male % 2 ? boys : men;
    maleSet.add(male);
  }
  
  return [...men].sort((a, b) => a - b).concat([...boys].sort((a, b) => b - a));
}