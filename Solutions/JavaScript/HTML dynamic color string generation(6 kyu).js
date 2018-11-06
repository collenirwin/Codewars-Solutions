var generateColor = function() {
  const hex = [ "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" ];
  let color = "#";
  
  for (let x = 0; x < 6; x++) {
    color += hex[Math.floor(Math.random() * hex.length)];
  }
  
  return color;
};