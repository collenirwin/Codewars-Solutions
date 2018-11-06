kata = {}
function kata.firstLua(a, b, c)
  str = a .. " " .. a * b
  
  if b < c then
    return str .. " Codewars"
  end
  
  return str .. " Lua"
end

return kata