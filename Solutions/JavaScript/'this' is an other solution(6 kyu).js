class OnceNamedOne {
  constructor(first, last) {
    this._firstName = first;
    this._lastName = last;
    this._fullName = this.firstName + " " + this.lastName;
  }
  
  get firstName() {
    return this._firstName;
  }
  
  get lastName() {
    return this._lastName;
  }
  
  get fullName() {
    return this._fullName;
  }
}