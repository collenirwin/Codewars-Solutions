function kebabize(str) {
  str = str.replace(/\d+/g, "");
  return str[0].toLowerCase() + str.substring(1)
    .replace(/([A-Z])/g, "-$1").toLowerCase();
}