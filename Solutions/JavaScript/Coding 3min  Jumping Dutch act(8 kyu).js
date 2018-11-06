function sc(floor) {
  const x = "here's some extra text";
  return floor <= 1
    ? "" 
    : "Aa~ ".repeat(floor - 1) + "Pa!" + (floor > 6 ? "" : " Aa!");
}