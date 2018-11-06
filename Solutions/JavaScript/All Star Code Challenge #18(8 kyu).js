function strCount(str, letter) {
  const matches = str.match(new RegExp(letter, "g"));
  return matches ? matches.length : 0;
}