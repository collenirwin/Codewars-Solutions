function toUnderscore(string) {
  string = string.toString();
  return string[0].toLowerCase() + 
    string.substring(1).split("").map(x => 
      x.match(/[A-Z]/) !== null ? "_" + x.toLowerCase() : x).join("")
}