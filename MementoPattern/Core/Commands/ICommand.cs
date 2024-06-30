namespace MementoPattern.Core.Commands;

internal interface ICommand
{
    void Execute();
    void Undo();
}
