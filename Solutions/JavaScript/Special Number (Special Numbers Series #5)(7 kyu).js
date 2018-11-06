function specialNumber(n) {
  return n.toString().split("").every(x => x < 6)
    ? "Special!!"
    : "NOT!!";
}