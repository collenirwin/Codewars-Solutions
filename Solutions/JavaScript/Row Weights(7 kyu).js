function rowWeights(array) {
  return array.reduce((t, x, i) => {
    t[i % 2] += x;
    return t;
  }, [0, 0]);
}