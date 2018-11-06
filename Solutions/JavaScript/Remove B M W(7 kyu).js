function removeBMW(str) {
  if (typeof(str) !== "string") {
    throw new Error("This program only works for text.");
  }
  
  ["b", "m", "w", "B", "M", "W"].forEach(x => str = str.split(x).join(""));
  
  return str;
}