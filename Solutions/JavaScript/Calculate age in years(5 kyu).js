/**
 * Return the difference between a birthdate and an optional "now" date, in years
 * 
 * @param {Date} birthDate
 * @param {Date} nowDate
 * @return  {Number}
 */
function getAge(birthDate, nowDate) {
  nowDate = nowDate || new Date();
  return nowDate.getFullYear() - birthDate.getFullYear() - 
    (nowDate.getMonth() < birthDate.getMonth() || 
    (nowDate.getMonth() === birthDate.getMonth() &&
    nowDate.getDate() < birthDate.getDate()));
}