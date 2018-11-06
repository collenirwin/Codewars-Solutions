public class Kata
{
  public static int? FoldTo(double distance)
  {
    if (distance <= 0)
    {
      return null;
    }
  
    double thickness = 0.0001;
    int folds = 0;
    while (thickness < distance)
    {
      thickness *= 2;
      folds++;
    }
    
    return folds;
  }
}