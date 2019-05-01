using System;
namespace Crockett95.UnityTest
{
  public class Bar: IBar
  {
    private IContext Context { get; set; }

    public string Tupac => "2Pac";
    public string Biggie => "Notorious B.I.G";
    public int Nas => (int)Math.Round(Math.Pow((double)Context.UserId, 2.0));

    public Bar(IContext context)
    {
      Context = context;
    }
  }
}
