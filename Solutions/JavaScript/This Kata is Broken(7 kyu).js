const vals = [71, 108, 97, 68, 79, 83];
let index = -1;

function solution() {
  index = index === vals.length - 1 ? 0 : index + 1;
  return vals[index];
}