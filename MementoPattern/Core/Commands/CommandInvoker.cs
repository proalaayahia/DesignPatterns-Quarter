namespace MementoPattern.Core.Commands;

internal class CommandInvoker
{
    private List<ICommand> _commands = [];
    public IReadOnlyCollection<ICommand> Commands => _commands;
    private Stack<ICommand> _executedCommands = new();
    private Stack<ICommand> _undoneCommands = new();
    public void AddCommand(ICommand command)
    {
        _commands.Add(command);
    }
    public void ExecuteCommands()
    {
        var commands = new List<ICommand>(_commands);
        foreach (ICommand command in commands)
        {
            ExecuteCommand(command);
        }
        ClearCommands();
    }

    public void ExecuteCommand(ICommand command)
    {
        AddCommand(command);
        command.Execute();
        _executedCommands.Push(command);
    }
    public void Undo()
    {
        if (_executedCommands.Any())
        {
            var command = _executedCommands.Pop();
            command.Undo();
            _undoneCommands.Push(command);
        }
    }
    public void Redo()
    {
        if (_undoneCommands.Any())
        {
            var command = _undoneCommands.Pop();
            ExecuteCommand(command);
        }
    }
    public void ClearCommands() => _commands.Clear();
}