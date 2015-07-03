class StringConverter
{
  const int max_count = 6;
  class BoolToString
  {
    void ConvertBoolToString(bool variable)
    {
      string variableToString = variable.ToString();
        Console.WriteLine(variableToString);
      }
  }
  public static void Main()
  {
    StringConverter.BoolToString boolString =
      new StringConverter.BoolToString();
    boolString.ConvertBoolToString(true);
  }
}
