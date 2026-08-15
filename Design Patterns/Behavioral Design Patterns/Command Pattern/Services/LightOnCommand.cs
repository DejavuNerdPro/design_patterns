

namespace Design_Patterns.Behavioral_Design_Patterns.Command_Pattern.Services
{
    public class LightOnCommand : ICommand
    {
        private LightPulb lightPulb = new();
        public void Execute() => lightPulb.On();

        public void Undo() => lightPulb.Off();
        
    }
}
