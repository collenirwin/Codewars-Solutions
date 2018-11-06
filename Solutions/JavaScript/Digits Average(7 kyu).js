function digitsAverage(input) {
  if (typeof(input) === "number") {
    input = input.toString().split("").map(x => parseInt(x));
  }
  
  if (input.length === 1) {
    return input[0];
  }
  
  const avgs = [];
  
  for (let x = 1; x < input.length; x++) {
    avgs.push(Math.ceil((input[x] + input[x - 1]) / 2));
  }
  
  return digitsAverage(avgs);
}