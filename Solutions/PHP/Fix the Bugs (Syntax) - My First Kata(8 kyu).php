function my_first_kata($a, $b) {
  if ((!is_int($a) and !is_float($a)) or (!is_int($b) and !is_float($b))) {
    return false;
  } else {
    return $a % $b + $b % $a;
  }
}