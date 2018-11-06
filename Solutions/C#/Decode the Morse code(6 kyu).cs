class MorseCodeDecoder
{
	public static string Decode(string morseCode)
	{
		var code = morseCode.Trim().Replace("   ", " | ").Split(' ');
    string message = "";
    
    foreach (var codeLetter in code)
    {
      message += codeLetter == "|" ? " " : MorseCode.Get(codeLetter);
    }
    
    return message;
	}
}