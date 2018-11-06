function checkExam(array1, array2) {
  return Math.max(0, array1.reduce((t, x, i) => {
    if (array2[i] === "") {
      return t;
    }
    else {
      return t += x === array2[i] ? 4 : -1
    }
  }, 0));
}