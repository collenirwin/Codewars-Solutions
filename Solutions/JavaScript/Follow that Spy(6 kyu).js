// it should return the places from the given routes
function findRoutes(routes) {
  let node = routes
    .filter(x => routes.reduce((t, y) => t + (y[1] === x[0]), 0) === 0)[0];
  const route = new Set(node);
  
  for (let x = 1; x < routes.length; x++) {
    node = routes.filter(x => x[0] === node[1])[0];
    route.add(...node);
  }
  
  route.add(node[1]);
  
  return [...route].join(", ");
}