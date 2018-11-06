const heapify = (array, n, i) => {
  let largest = i;
  const left = 2 * i + 1;
  const right = 2 * i + 2;

  if (left < n && array[i] < array[left]) {
    largest = left;
  }

  if (right < n && array[largest] < array[right]) {
    largest = right;
  }

  if (largest !== i) {
    const temp = array[i];
    array[i] = array[largest];
    array[largest] = temp;
    
    heapify(array, n, largest);
  }
};

Array.prototype.sort = function() {
  for (let x = this.length; x > -1; x--) {
    heapify(this, this.length, x);
  }
  
  for (let x = this.length - 1; x > 0; x--) {
    const temp = this[x];
    this[x] = this[0];
    this[0] = temp;
    
    heapify(this, x, 0);
  }
  
  return this;
}