import java.math.BigInteger;

public class LargeSum {

  public static String firstTenDigitsOfSum(String[] numbers) {
    BigInteger sum = new BigInteger("0");
    
    for (String number : numbers) {
      sum = sum.add(new BigInteger(number));
    }
  
    return sum.toString().substring(0, 10);
  }
}