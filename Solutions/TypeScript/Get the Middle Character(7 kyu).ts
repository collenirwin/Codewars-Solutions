export class Challenge {
  static getMiddle(s:string) {
    var mid = Math.floor(s.length / 2);
    return s.length % 2 == 0
      ? s[mid - 1] + s[mid]
      : s[mid];
  }
}