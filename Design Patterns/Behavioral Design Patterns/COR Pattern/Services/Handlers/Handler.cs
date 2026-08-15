
namespace Design_Patterns.Behavioral_Design_Patterns.COR_Pattern.Services.Handlers
{
    public abstract class Handler
    {
        protected Handler next;
        
        public void setNext(Handler next)
        {
            this.next = next;
        }

        public abstract void Handle(decimal withdrawAmount);
    }
}
