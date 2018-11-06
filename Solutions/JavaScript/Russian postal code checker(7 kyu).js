function zipvalidate(postcode) {
  return /^[1-4|6]\d{5}$/.test(postcode);
}