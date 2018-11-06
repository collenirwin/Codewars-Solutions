function scrollingText(text) {
  text = text.toUpperCase();
  const rotations = [text];
  
  for (let x = 0; x < text.length - 1; x++) {
    text = text.substring(1) + text[0];
    rotations.push(text);
  }
  
  return rotations;
}