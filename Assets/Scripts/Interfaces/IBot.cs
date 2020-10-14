using Types;

namespace Interfaces
{
    public interface IBot
    {
        int Health { get; }
        CellResult Move(Direction moveDirection);
        CellResult Interact(Direction interactDirection);
        CellResult Look(Direction lookDirection);
    }
}