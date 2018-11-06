public class Bus
{
	public static string arbitrate(string input, int length)
	{
    int index = input.IndexOf("1");
		return index != -1
      ? input.Substring(0, index + 1) + input.Substring(index + 1).Replace("1", "0")
      : input;
	}
}