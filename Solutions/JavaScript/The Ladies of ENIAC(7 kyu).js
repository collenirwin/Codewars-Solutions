function radLadies(name) {
  return name.replace(/[^a-z\s!]/gi, "").toUpperCase();
}