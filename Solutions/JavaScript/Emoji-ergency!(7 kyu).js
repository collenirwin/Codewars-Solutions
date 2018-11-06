const insert = (string) => {
  const emoji = {
    "[[f9.smile]]"        :     ":)",
    "[[f9.grin]]"         :     ":D",
    "[[f9.smiley]]"       :     "=)",
    "[[f9.sohappy]]"      :     "XD",
    "[[f9.tongue]]"       :     ":P",
    "[[f9.wink]]"         :     ";)",
    "[[f9.sad]]"          :     ":(",
    "[[f9.slant]]"        :     ":/",
    "[[f9.surprised]]"    :     ":O",
    "[[f9.catface]]"      :     ":3",
    "[[f9.cool]]"         :     "B)",
    "[[f9.unimpressed]]"  :     ":|",
    "[[f9.angry]]"        :     ">:|",
    "[[f9.kissing]]"      :     "^.^",
    "[[f9.dazed]]"        :     "*_*",
    "[[f9.dance1]]"       :     "<(^.^<)",
    "[[f9.dance2]]"       :     "(>^.^)>",
    "[[f9.heart]]"        :     "<3"
  }
  
  for (let key in emoji) {
    string = string.split(key).join(emoji[key]);
  }
  
  return string;
}