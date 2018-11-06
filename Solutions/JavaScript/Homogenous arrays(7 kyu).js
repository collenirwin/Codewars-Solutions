function filterHomogenous(arrays) {
  // Alea iacta est, code legionary!
  return arrays.filter(x => x.length > 0 && x.length === x.filter(y => typeof(y) === typeof(x[0])).length);
}