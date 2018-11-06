const flatten = arr => {
  return [].concat(...arr
    .map(x => Array.isArray(x)
      ? flatten(x)
      : x));  
};

const sumNested = arr => {
  return arr && arr.length !== 0 
    ? flatten(arr).reduce((t, x) => t + x, 0)
    : 0;
};