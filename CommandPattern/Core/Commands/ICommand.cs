namespace CommandPattern.Core.Commands;

internal interface ICommand
{
    void Execute();
    void Undo();
}
