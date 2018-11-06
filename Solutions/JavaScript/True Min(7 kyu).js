function min(a, b) {
  if (a === null) a = 0;
  if (b === null) b = 0;
  if (isNaN(parseFloat(a)) || isNaN(parseFloat(a))) return NaN;
  return (a<b)?a:b;
}