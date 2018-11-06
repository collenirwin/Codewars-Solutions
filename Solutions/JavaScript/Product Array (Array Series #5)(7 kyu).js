function productArray(numbers) {
  return numbers.map((x, i) =>
    numbers.reduce((t, y, idx) => t * (i === idx ? 1 : y), 1));
}