function hidePasswordFromConnection(urlString) {
  return urlString.replace(/password=([^&]+)/, (a, b) => 
    "password=" + b.split("").map(x => "*").join(""));
}