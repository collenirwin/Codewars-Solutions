const ordered = [
  ":D",
  ":)",
  ":|",
  ":(",
  "T_T"
];

function sortEmotions(arr, order) {
  // (ง •̀_•́)ง
  arr.sort((x, y) => ordered.indexOf(x) - ordered.indexOf(y));
  return order ? arr : arr.reverse();
}