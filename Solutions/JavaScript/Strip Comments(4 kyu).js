function solution(input, markers) {
  const remove = (line) => {
    for (let marker of markers) {
      line = line.replace(new RegExp(
        marker.replace(/[-\/\\^$*+?.()|[\]{}]/g, '\\$&') + "(.?)+", "g"), "").trim();
    }
    
    return line;
  };
  
  return input.split("\n").map(x => remove(x)).join("\n");
}