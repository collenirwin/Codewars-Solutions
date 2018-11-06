#include <vector>
#include <string>
#include <math.h>

std::string payCheese(std::vector<int> arr)
{
  double hours = 0.0;

  for (int x = 0; x < arr.size(); x++)
  {
    hours += arr.at(x) / 100.0;
  }
  
  return "£" + std::to_string((int)(ceil(hours) * 8.75 * 4));
}