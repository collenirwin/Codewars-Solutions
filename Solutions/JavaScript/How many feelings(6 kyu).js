function countFeelings(string, array) {
  const count = array.filter(x => x.split("").filter(y => string.indexOf(y) !== -1).length === x.length).length;
  return count === 1
    ? count + " feeling."
    : count + " feelings.";
}