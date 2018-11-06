String.prototype.reverse = function() {
  return this.split("").reverse().join("");
}

function encryptNum(number) {console.log(number);
  if (!/^(\+39|0039|1)([ .-]?\d{3}){2}[ .-]?\d{4}$/.test(number)) {
    return false;
  }

  number = number.reverse();

  for (let x = 0; x < 6; x++) {
    number = number.replace(/\d(.*)$/, (a, b) => "X" + b);
  }

  return number.reverse();
}