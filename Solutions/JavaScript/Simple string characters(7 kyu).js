function solve(s) {
  const l = [0, 0, 0, 0];
  
  for (let x of s) {
    if (/[A-Z]/.test(x)) {
      l[0]++;
    }
    else if (/[a-z]/.test(x)) {
      l[1]++;
    }
    else if (/\d/.test(x)) {
      l[2]++;
    }
    else {
      l[3]++;
    }
  }
  
  return l;
}