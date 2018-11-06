function isValidCoordinates(coordinates) {
  const coords = coordinates.split(", ").map(x => Math.abs(parseInt(x)));
  
  if (!coordinates || !coords[0] || !coords[1] ||
    coords[0] < 0 || coords[0] > 90 ||
    coords[1] < 0 || coords[1] > 180)
  {
    return false;
  }

  return /^-?\d+\.?\d*, -?\d+\.?\d*$/.test(coordinates);
}