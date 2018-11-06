#include <stddef.h>

int sum_array(const int *values, size_t count)
{
  int output = 0;
  for (int x = 0; x < count; x++)
  {
    output += values[x];
  }
  return output;
}