function validISBN10(isbn) {
  return isbn.length === 10 && isbn
    .split("")
    .reduce((t, x, i) => t + (x === "X" && i === 9 ? 10 : x) * (i + 1), 0)
    % 11 === 0;
}