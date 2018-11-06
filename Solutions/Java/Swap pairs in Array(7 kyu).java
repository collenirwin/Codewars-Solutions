public class Swappairs {

  public Object[][][] swapp(Object[][] input) {
    Object[][] outp = new Object[input.length][2];
    
    for (int x = 0; x < input.length; x++) {
       outp[x][0] = input[x][1];
       outp[x][1] = input[x][0];
    }
    
    return new Object[][][] { input, outp };
  }
}