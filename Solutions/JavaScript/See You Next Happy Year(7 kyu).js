function nextHappyYear(year) {
  do {
    year++;
  } while (new Set(year.toString()).size !== 4)
  
  return year;
}