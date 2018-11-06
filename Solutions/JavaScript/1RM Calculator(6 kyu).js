function calculate1RM(w, r) {
  if (r <= 0) {
    return 0;
  }
  
  if (r === 1) {
    return w;
  }

  return Math.round(Math.max(w * (1 + r / 30),
    (100 * w) / (101.3 - 2.67123 * r),
    w * Math.pow(r, 0.1)), 0);
}