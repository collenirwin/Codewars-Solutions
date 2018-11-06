// TITLES is a preloaded array of String to search throught

function search(searchTerm) {
  searchTerm = searchTerm.toLowerCase();
  return TITLES.filter(x => x.toLowerCase().indexOf(searchTerm) !== -1);
}