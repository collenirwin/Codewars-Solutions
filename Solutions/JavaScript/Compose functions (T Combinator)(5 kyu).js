var compose = function() {
  const args = [...arguments];
  
  if (args.length < 2) {
    return args[0];
  }
  
  for (let x = 1; x < args.length; x++) {
    args[0] = args[x](args[0]);
  }
  
  return args[0];
};