function toCsvText(array) {
   return array.reduce((t, a) =>
     t += a.reduce((t2, x) =>
       t2 += x + ",", "").slice(0, -1) + "\n", "").slice(0, -1);
}