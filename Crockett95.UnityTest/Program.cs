using System;
using Unity;

namespace Crockett95.UnityTest
{
  class Program
  {
    private static Program Instance { get; set; }

    public static T Resolve<T>()
    {
      return Instance.container.Resolve<T>();
    }

    static void Main(string[] args)
    {
      Instance = new Program();
      Instance.Run();
    }

    private readonly IUnityContainer container = new UnityContainer();

    private Program()
    {
      RegisterTypes();
    }

    private void Run()
    {
      Console.WriteLine(Foo.GetBar());
    }

    private void RegisterTypes()
    {
      container.RegisterType<IFoo, Foo2>();
      container.RegisterType<IBar, Bar>();
      container.RegisterInstance<IContext>(new Context(134, "crockett95", "prmpsql18"));
    }
  }
}
