

namespace Design_Patterns.Behavioral_Design_Patterns.Command_Pattern.Services
{
    public class RemoteControl
    {
        ICommand command;

        public void setCommand(ICommand command)
        {
            this.command = command;
        }

        public void On() => command.Execute();
        public void Off() => command.Undo();

    }
}
