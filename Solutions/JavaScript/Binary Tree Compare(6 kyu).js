// return true if the binary trees rooted and a and b are equal in structure and value
// return false otherwise
function compare(a, b) {
  if (!a || !b) {
    return a === b;
  }
  
  return a.val === b.val && compare(a.left, b.left) && compare(a.right, b.right);
}
5 months agoRefactor
// return true if the binary trees rooted and a and b are equal in structure and value
// return false otherwise
function compare(a, b) {
  if (!a || !b) {
    return a === b;
  }
  
  if (a.val === b.val) {
    return compare(a.left, b.left) && compare(a.right, b.right);
  }
  
  return false;
}