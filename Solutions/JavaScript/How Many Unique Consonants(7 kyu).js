function countConsonants(str) {
  const matches = [...new Set(str.toLowerCase())]
    .join("")
    .match(/(?=[^aeiou])(?=[a-z])/g);
    
  return matches ? matches.length : 0;
}