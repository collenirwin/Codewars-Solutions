function orArrays(arr1, arr2, or) {
  return arr1.length > arr2.length
    ? arr1.map((x, i) => x | (arr2[i] || or))
    : arr2.map((x, i) => x | (arr1[i] || or));
}