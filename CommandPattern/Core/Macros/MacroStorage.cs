using CommandPattern.Core.Commands;

namespace CommandPattern.Core.Macros;

internal class MacroStorage
{
    private MacroStorage()
    {

    }
    public static MacroStorage Instance { get; } = new();
    private List<Macro> Macros = [];
    public IReadOnlyCollection<Macro> GetMacros() => Macros;
    public void CreateMacro(IEnumerable<ICommand> commands)
    {
        Macro macro = new(Macros.Count + 1, commands);
        Macros.Add(macro);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"macro #{macro.Id} saved.");
        Console.ForegroundColor = ConsoleColor.White;
    }
    public Macro GetMacro(int id) => Macros.FirstOrDefault(m => m.Id == id)!;
}