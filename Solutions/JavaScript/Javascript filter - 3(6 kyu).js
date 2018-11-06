function searchNames(logins) {
  return logins.filter((x, i) => i % 2 === 1 && (logins[i - 1][0] === "." || logins[i - 1].slice(-1) === "."));
}