function greetDevelopers(list) {
  for (let x of list) {
    x.greeting = `Hi ${x.firstName}, what do you like the most about ${x.language}?`;
  }
  
  return list;
}