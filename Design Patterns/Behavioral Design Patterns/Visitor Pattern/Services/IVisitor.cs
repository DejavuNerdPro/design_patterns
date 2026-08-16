

namespace Design_Patterns.Behavioral_Design_Patterns.Visitor_Pattern.Services
{
    public interface IVisitor
    {
        public void visit(Doctor doctor);
        public void visit(Nurse nurse);
        public void visit(Patient patient);
    }
}
