using System;
namespace Crockett95.UnityTest
{
  public interface IContext
  {
    string Name { get; }
    string Dsn { get; }
    int UserId { get; }
  }
}
