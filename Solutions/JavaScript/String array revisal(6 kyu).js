function dup(s) {
  return s.map(x => x.replace(/(.)\1+/g, "$1"));
}