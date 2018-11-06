makes10=(a,b)=>/10/.test([a,b,a+b])
7 months agoRefactor
8 kyu
Determine offspring sex based on genes XX and XY chromosomes
C#:

public class Kata
{
  public static string ChromosomeCheck(string sperm)
  {
    return sperm == "XX"
      ? "Congratulations! You're going to have a daughter."
      : "Congratulations! You're going to have a son.";
  }
}