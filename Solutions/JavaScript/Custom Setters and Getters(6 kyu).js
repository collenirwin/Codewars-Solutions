class Archiver {
  constructor() {
    this._temperature = null;
    this._archive = [];
  }
  
  get temperature() {
    return this._temperature;
  }
  
  set temperature(temperature) {
    this._archive.push({ date: new Date(), val: temperature });
    this._temperature = temperature;
  }
  
  getArchive() {
    return this._archive;
  }
}