function buildInvertedIndex(collection, term, caseSensitive, exactMatch) {
  let regex;
  const flags = caseSensitive ? "" : "i";
  
  if (exactMatch) {
    regex = new RegExp("\\b" + term + "\\b", flags);
  }
  else {
    regex = new RegExp(term, flags);
  }
  
  return collection.reduce((t, x, i) => {
    if (regex.test(x)) {
      t.push(i + 1);
    }
    
    return t;
  }, []);
}