function well(ideas) {
  const good = ideas
    .reduce((t, x) => t + x
      .filter(y => y.toString().toLowerCase() === "good").length, 0);
    
  if (good === 0) {
    return "Fail!";
  }
  else if (good < 3) {
    return "Publish!";
  }
  
  return "I smell a series!";
}