var addStaticMethod = function(clss, name, method) {
  clss[name] = method;
  clss.prototype[name] = () => clss[name]();
};