const whosOnline = (friends) => {
  const output = {};
  
  const online = [];
  const offline = [];
  const away = [];
  
  for (let friend of friends) {
    if (friend.status === "offline") {
      offline.push(friend.username);
    }
    else if (friend.lastActivity > 10) {
      away.push(friend.username);
    }
    else {
      online.push(friend.username);
    }
  }
  
  if (online.length) {
    output.online = online;
  }
  
  if (offline.length) {
    output.offline = offline;
  }
  
  if (away.length) {
    output.away = away;
  }
  
  return output;
}