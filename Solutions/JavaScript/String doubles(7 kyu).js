function doubles(s) {
  while (s.match(/(\w)\1{1}/g))
  {
    s = s.replace(/(\w)\1{1}/g, "");
  }
  return s;
}