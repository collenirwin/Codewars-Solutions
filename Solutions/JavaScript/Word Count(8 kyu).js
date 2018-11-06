function countWords(str) {
  const words = str.match(/\b\S+\b/g);
  return words ? words.length : 0;
}