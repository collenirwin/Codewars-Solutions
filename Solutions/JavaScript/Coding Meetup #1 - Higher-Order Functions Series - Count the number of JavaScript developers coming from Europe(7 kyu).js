function countDevelopers(list) {
  return list.reduce((t, x) => t + (x.continent === "Europe" && x.language === "JavaScript"), 0);
}