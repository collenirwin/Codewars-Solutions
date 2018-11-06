class NamedOne {
  constructor(first, last) {
    this.firstName = first;
    this.lastName = last;
  }
  
  get fullName() {
    return this.firstName + " " + this.lastName;
  }
  
  set fullName(name) {
    name = name.split(" ");
    if (name.length !== 2) {
      return;
    }
    
    this.firstName = name[0];
    this.lastName = name[1];
  }
}