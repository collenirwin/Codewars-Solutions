def calculate(a, o, b)
 if(o == "+") 
   return a + b
 end
 if(o == "-")
   return a - b
 end
 if(o == "/" and b != 0) 
   return a / b
 end
 if(o == "*") 
   return a * b
 end
 
 return nil 
end