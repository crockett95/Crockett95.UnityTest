using System;
namespace Crockett95.UnityTest
{
  public partial class Foo : IFoo
  {
    protected static IFoo Instance => Program.Resolve<IFoo>();

    public static string GetBar()
    {
      return Instance.Bar();
    } 
  }
}
