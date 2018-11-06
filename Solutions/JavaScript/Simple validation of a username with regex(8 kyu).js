function validateUsr(username) {
  return /^[a-z_\d]{4,16}$/.test(username);
}