function maxTriSum(numbers) {
  return [...new Set(numbers)]
    .sort((x, y) => y - x)
    .slice(0, 3)
    .reduce((t, x) => t + x);
}