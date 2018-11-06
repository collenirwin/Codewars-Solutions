function swapper(a, b) {
  /*
   HINTS: uncomment out the following line
   for a series of hints to help you with the 
   bitwise stuff if you get stuck...
   (There are three HINTS indexed 0,1, and 2, respectively)
  */
  a ^= b;
  b ^= a;
  a ^= b;
  
  return [a, b]
}