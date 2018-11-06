function whatNumberIsIt(n) {
  if (isNaN(n)) {
    return "Input number is Number.NaN";
  }

  switch (n) {
    case Number.MAX_VALUE: return "Input number is Number.MAX_VALUE";
    case Number.MIN_VALUE: return "Input number is Number.MIN_VALUE";
    case Number.NEGATIVE_INFINITY: return "Input number is Number.NEGATIVE_INFINITY";
    case Number.POSITIVE_INFINITY: return "Input number is Number.POSITIVE_INFINITY";
    default: return `Input number is ${n}`;
  };
}