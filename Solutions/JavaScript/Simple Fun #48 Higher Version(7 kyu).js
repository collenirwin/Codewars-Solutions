function higherVersion(ver1, ver2) {
  var v1 = ver1.split(".").map((x) => parseInt(x));
  var v2 = ver2.split(".").map((x) => parseInt(x));
  
  for (var x = 0; x < v1.length; x++) {
    if (v1[x] == v2[x]) {
      continue;
    }
    
    return v1[x] > v2[x];
  }
  
  return false;
}