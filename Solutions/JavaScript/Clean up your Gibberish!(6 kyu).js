function cleanItUp(data) {
  data = data.replace(/[^a-z]/gi, "").toLowerCase();
  const words = [];
  
  for (let x = 0; x < data.length - 4; x += 5) {
    words.push(data[x].toUpperCase() + data.slice(x + 1, x + 5));
  }
  
  return words.join(" ");
}