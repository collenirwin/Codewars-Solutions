function validate(username, password){
  var database = new Database();
  if (password.indexOf("||") + password.indexOf("//") !== -2) {
    return 'Wrong username or password!';
  }
  return database.login(username, password);
}