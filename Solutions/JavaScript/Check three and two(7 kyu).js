function checkThreeAndTwo(array) {
  const counts = Object.values(array.reduce((t, x) => {
    t[x]++;
    return t;
  }, {a: 0, b: 0, c: 0}));
  
  return counts.includes(3) && counts.includes(2);
}