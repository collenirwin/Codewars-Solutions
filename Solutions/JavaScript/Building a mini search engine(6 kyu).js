function searchEng(string, searchWord, searchMethod, newWord) {
  newWord = newWord || "";
  
  // make sure searchMethod is either 1 or 2, and searchWord and newWord are strictly alphanumeric
  if (![1, 2].includes(searchMethod) || !/^[\w\d]+$/.test(searchWord + newWord)) {
    return "No valid input";
  }
  
  // full expression: /\bsearchWord\b/g
  const regex = new RegExp(/\b/.source + searchWord + /\b/.source, "g");
  const matches = string.match(regex) || [];
  
  // search
  if (searchMethod === 1) {
    return { matches: matches.length, newString: "" };
  }
  
  // search and replace
  return { matches: matches.length, newString: string.replace(regex, newWord) };
}