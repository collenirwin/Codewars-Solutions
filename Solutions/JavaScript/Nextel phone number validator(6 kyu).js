var isValidNextelPhoneNumber = function(str) {
  return /^\d+\*\d+\*\d+$/.test(str.replace(/\s/g, ""));
};