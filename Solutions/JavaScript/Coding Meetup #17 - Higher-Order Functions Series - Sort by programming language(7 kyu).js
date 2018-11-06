function sortByLanguage(list) {
  return list.sort((a, b) => {
    if (a.language < b.language) {
      return -1;
    }
    
    if (a.language > b.language) {
      return 1;
    }
    
    if (a.firstName < b.firstName) {
      return -1;
    }
    
    if (a.firstName > b.firstName) {
      return 1;
    }
    
    return 0;
  });
}