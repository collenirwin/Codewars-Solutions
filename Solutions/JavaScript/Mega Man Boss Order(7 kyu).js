function getBossOrder(bosses) {
  let boss = bosses.find(x => x.difficulty === 1);
  const order = [boss.name];
  
  for (let x = 0; x < bosses.length - 1; x++) {
    boss = bosses.find(x => x.weakness === boss.weapon);
    order.push(boss.name);
  }
  
  return order;
}