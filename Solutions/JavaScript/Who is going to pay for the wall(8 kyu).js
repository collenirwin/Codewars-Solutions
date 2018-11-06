function whoIsPaying(name) {
  name = [name];
  
  if (name[0].length > 2) {
    name.push(name[0].substring(0, 2));
  }
  
  return name;
}