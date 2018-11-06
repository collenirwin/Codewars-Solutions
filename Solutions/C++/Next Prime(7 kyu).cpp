#include <math.h>

bool isPrime(int num)
{
  if (num < 2) return false;
  if (num == 2) return true;
  if (num % 2 == 0) return false;
  
  for (int x = 3; x <= sqrt(num); x += 2)
  {
    if (num % x == 0)
    {
      return false;
    }
  }
  
  return true;
}

int nextPrime(int num)
{
  while (true)
  {
    if (isPrime(++num))
    {
      return num;
    }
  }
}