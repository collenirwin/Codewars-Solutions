function anagrams(word, words) {
  word = word.split("").sort().join("");
  return words.filter(x => x.split("").sort().join("") === word);
}