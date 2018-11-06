package kata

import "math"

func combat(health, damage float64) float64 {
  return math.Max(health - damage, 0)
}