using CommandPattern.Core.Commands;

namespace CommandPattern.Core.Macros;

internal class Macro
{
    public Macro(int id, IEnumerable<ICommand> commands)
    {
        Id = id;
        Commands = commands;
    }
    public int Id { get; }
    public IEnumerable<ICommand> Commands { get; private set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
