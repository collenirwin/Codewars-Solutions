function isKiss(words) {
  words = words.split(" ");
  return words.reduce((m, x) => x.length > m ? x.length : m, -1) > words.length
    ? "Keep It Simple Stupid"
    : "Good work Joe!";
}