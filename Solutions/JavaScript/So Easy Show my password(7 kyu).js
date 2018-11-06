function showMyPassword(birthdays) {
  birthdays = birthdays.map(x => new Date(x)).sort((a, b) => a - b);
  
  return birthdays[2].getFullYear().toString().substring(2) +
    birthdays[3].getFullYear().toString().substring(2) +
    (birthdays[0].getMonth() + 1).toString().padStart(2, "0") +
    birthdays[1].getDate().toString().padStart(2, "0");
}