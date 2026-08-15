

namespace Design_Patterns.Behavioral_Design_Patterns.Command_Pattern.Services
{
    public class FunCommand : ICommand
    {
        private Fun fun = new();
        public void Execute() => fun.On();

        public void Undo() => fun.Off();
        
    }
}
