function keysAndValues(data) {
  const names = Object.getOwnPropertyNames(data);
  return [ names, names.map(x => data[x]) ];
}