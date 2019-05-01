using System;
namespace Crockett95.UnityTest
{
  public class Context: IContext
  {
    public string Name { get; private set; }
    public string Dsn { get; private set; }
    public int UserId { get; private set; }

    public Context(int userId, string name, string dsn)
    {
      Name = name;
      Dsn = dsn;
      UserId = userId;
    }
  }
}
