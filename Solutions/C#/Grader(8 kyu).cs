public class Kata
{
  public static char Grader(double score)
  {
    // heheheheh
    return score < 0.6
      ? 'F'
      : score < 0.7
        ? 'D'
        : score < 0.8
          ? 'C'
          : score < 0.9
            ? 'B'
            : score <= 1.0
              ? 'A'
              : 'F';
  }
}