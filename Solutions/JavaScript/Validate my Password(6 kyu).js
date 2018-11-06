function validPass(password) {
  return /^(?=.*\d)(?=.*\w)[\w\d]{4,19}$/.test(password)
    ? "VALID"
    : "INVALID";
}