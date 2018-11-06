const lower = "abcdefghijklmnopqrstuvwxyz";
const upper = lower.toUpperCase();

function lettersToNumbers(s) {
  return s.split("").reduce((t, x) => {
    let index;
  
    if ((index = lower.indexOf(x)) !== -1) {
      return t + index + 1;
    }
    
    if ((index = upper.indexOf(x)) !== -1) {
      return t + (index + 1) * 2;
    }
    
    if (!isNaN(x) && x !== " ") {
      return t + parseInt(x);
    }
    
    return t;
  }, 0);
}