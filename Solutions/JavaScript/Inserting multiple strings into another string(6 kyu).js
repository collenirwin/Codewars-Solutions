function insert_at_indexes(phrase, word, indexes) {
  let d = 0;
  
  for(let x = 0; x < indexes.length; x++) {
    phrase = phrase.slice(0, indexes[x] + d) +
      word + 
      phrase.slice(indexes[x] + d);
    d += word.length;
  }
  
  return phrase;
}