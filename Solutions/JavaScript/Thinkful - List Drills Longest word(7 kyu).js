function longest(words) {
  return words.reduce((t, x) => Math.max(t, x.length), 0);
}