function pofi(n) {
  return n % 4 === 0
    ? "1"
    : n % 4 === 1
      ? "i"
      : n % 4 === 2
        ? "-1"
        : n % 4 === 3
          ? "-i"
          : "N/A";
}