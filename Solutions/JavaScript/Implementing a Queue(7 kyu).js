class Queue {
  constructor() {
    this.a = [];
  }
  
  enqueue(item) {
    this.a.push(item);
  }
  
  dequeue() {
    return this.a.shift();
  }
  
  size() {
    return this.a.length;
  }
}