function stringExpansion(s) {
  return s.replace(/(\d[^\d]+)/g, (_, x) => 
    x.slice(1).split("").map(y => y.repeat(x[0])).join(""))
      .replace(/\d+/g, "");
}