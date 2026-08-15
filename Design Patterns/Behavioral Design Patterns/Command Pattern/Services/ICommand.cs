

namespace Design_Patterns.Behavioral_Design_Patterns.Command_Pattern.Services
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
