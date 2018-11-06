function highAndLow(numbers) {
  numbers = numbers.split(" ").sort((a, b) => a - b);
  return `${numbers[numbers.length - 1]} ${numbers[0]}`;
}