function isValidIP(str) {
  console.log(str + "!");
  const octets = str.split(".");
  
  if (octets.length != 4) {
    return false;
  }
  
  for (let x = 0; x < octets.length; x++) {
    const octet = octets[x];
    if (isNaN(octet) || 
      parseInt(octet) > 255 || 
      (octet[0] === "0" && octet.length > 1) || 
      octet.length != octet.trim().length)
    {
      return false;
    }
  }
  
  console.log(true);
  return true;
}