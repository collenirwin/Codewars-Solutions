function myFunction() {
  var MyObject = {
    objProperty: "string",
    objMethod: function() {
      return this.objProperty;
		}
  };
  
  return MyObject;
};