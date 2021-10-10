using static Newtonsoft.Json.JsonConvert;

namespace Library
{
  public class CalcUs
  {
    public int Get(int left, int right) =>
        DeserializeObject<int>($"{left + right}");
  }
}
