namespace Triangle
{
  bool isTriangle(int a, int b, int c)
  {
    long x = a;
    long y = b;
    long z = c;
  
    return x + y > z && x + z > y && y + z > x;
  }
};