using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
  public class MockCommanderRepo : ICommanderRepo
  {
    public IEnumerable<Command> GetAppCommands()
    {
      var commands = new List<Command>
      {
        new Command{Id=0, HowTo="Mock1", Line="lineMock1", Platform="platMock1"},
        new Command{Id=0, HowTo="Mock2", Line="lineMock2", Platform="platMock2"},
        new Command{Id=0, HowTo="Mock3", Line="lineMock3", Platform="platMock3"}
      };

      return commands;
    }

    public Command GetCommandById(int id)
    {
      return new Command{Id=0, HowTo="Get that bread", Line="Profit", Platform="Earth"};
    }
  }
}