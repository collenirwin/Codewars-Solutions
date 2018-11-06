function recycleMe(recycle) { 
  return [
    recycle.filter(x => x > 0).length,
    recycle.filter(x => x < 0).length,
    recycle.filter(x => x === 0).length
  ];
}