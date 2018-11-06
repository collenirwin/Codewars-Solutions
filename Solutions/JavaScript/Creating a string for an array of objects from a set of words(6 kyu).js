function wordsToObject(input) {
  return "[" + input
    .split(/(\S+\s\S+)(?:\s)/)
    .filter(x => x)
    .map(x => {
      x = x.split(" ");
      return `{name : '${x[0]}', id : '${x[1]}'}`;
    })
    .join(", ") + "]";
}