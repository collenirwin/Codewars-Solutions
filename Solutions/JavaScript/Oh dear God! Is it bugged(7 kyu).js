function isItBugged(code) {
 return /[0-3][0-9]\-[0-1][0-9]\-[0-9][0-9][0-9][0-9]\s[0-2][0-9]:[0-6][0-9]/.test(code);
}