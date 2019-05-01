using System;
namespace Crockett95.UnityTest
{
  public class Foo2: IFoo
  {
    private IContext Context { get; set; }
    private IBar Baz { get; set; }

    public string Bar()
    {
      return string.Format($"{Baz.Tupac} is being run by user {Context.Name} (user id {Context.UserId.ToString()})");
    }

    public Foo2(IContext context, IBar bar)
    {
      Context = context;
      Baz = bar;
    }
  }
}
