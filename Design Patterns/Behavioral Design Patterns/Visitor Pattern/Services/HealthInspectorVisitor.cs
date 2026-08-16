

namespace Design_Patterns.Behavioral_Design_Patterns.Visitor_Pattern.Services
{
    public class HealthInspectorVisitor : IVisitor
    {
        public void visit(Doctor doctor)
        {
            Console.WriteLine($"Health Inspector inspects {doctor.Id} - {doctor.Name} doctor.");
        }

        public void visit(Nurse nurse)
        {
            Console.WriteLine($"Health Inspector inspects {nurse.Id} - {nurse.Name} nurse.");
        }

        public void visit(Patient patient)
        {
            Console.WriteLine($"Health Inspector inspects {patient.Id} - {patient.Name} patient.");
        }
    }
}
