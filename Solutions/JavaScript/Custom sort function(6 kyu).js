function sort(items) {
  if (!items || items.length === 0) {
    return items;
  }

  let changed = true;
  while (changed) {
    changed = false;
    
    for (let x = 1; x < items.length; x++) {
      if (items[x] < items[x - 1]) {
        const temp = items[x];
        items[x] = items[x - 1];
        items[x - 1] = temp;
        
        changed = true;
      }
    }
  }
  
  return items;
}