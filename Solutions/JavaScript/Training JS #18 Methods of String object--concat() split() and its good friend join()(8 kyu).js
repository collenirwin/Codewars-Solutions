function splitAndMerge(str, sp) {
  return str.split(" ").map(x => x.split("").join(sp)).join(" ");
}