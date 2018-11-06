public static class Kata
{
    public static string HowManyDalmatians(int number)
    {
        var dogs = new string[]
        {
            "Hardly any",
            "More than a handful!",
            "Woah that's a lot of dogs!",
            "101 DALMATIONS!!!"
        };
        
        if (number <= 10) 
          return dogs[0];
        else if (number <= 50)
          return dogs[1];
        else if (number == 101)
          return dogs[3];
          
        return dogs[2];
    }
}