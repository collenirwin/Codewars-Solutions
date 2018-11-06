function makeSentence(parts) {
  return (parts.join(" ") + ".")
    .replace(/ ,/g, ",")
    .replace(/ \./g, ".")
    .replace(/\.{2,}/g, ".");
}