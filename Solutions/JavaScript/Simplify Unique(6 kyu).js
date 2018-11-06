const allowed = "0132456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ -";
const urls = [];

function simunq(original) {
  original = original.split("").map(x => allowed.indexOf(x) === -1 ? "-" : x).join("");
  
  let url = original;
  let count = 2;
  while (urls.indexOf(url) !== -1) {
    url = original + "-" + count++;
  }
  
  urls.push(url);
  return url;
}
simunq.reset = function() {
  urls.length = 0;
};