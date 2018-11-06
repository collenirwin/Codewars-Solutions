function isValid(idn) {
  return /^[$a-z_][$a-z_\d]+$/i.test(idn);
}