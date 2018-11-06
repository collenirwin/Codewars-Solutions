function gearInchCalculator(chainrings, sprockets) {
	const wheelDiameter = 26;
  const output = [];
  
  for (let x = 0; x < chainrings.length; x++) {
    output.push([]);
    
    for (let sprocket of sprockets) {
      output[x].push(
        Math.round((wheelDiameter * (chainrings[x] / sprocket)) * 10) / 10);
    }
  }
  
  return output;
}