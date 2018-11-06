function spinWords(input) {
  return input
    .split(" ")
    .map(x => x.length > 4 ? x.split("").reverse().join("") : x)
    .join(" ");
}