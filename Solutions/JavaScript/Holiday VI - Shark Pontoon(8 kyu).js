function shark(pontoonDistance, sharkDistance, youSpeed, sharkSpeed, dolphin) {
  if (dolphin) {
    sharkSpeed /= 2;
  }

  return pontoonDistance / youSpeed > sharkDistance / sharkSpeed
    ? "Shark Bait!"
    : "Alive!";
}