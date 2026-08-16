

namespace Design_Patterns.Behavioral_Design_Patterns.Visitor_Pattern.Services
{
    public class TaxOfficerVisitor : IVisitor
    {
        public void visit(Doctor doctor)
        {
            Console.WriteLine($"Tax Officer inspects {doctor.Id} - {doctor.Name} doctor.");
        }

        public void visit(Nurse nurse)
        {
            Console.WriteLine($"Tax Officer inspects {nurse.Id} - {nurse.Name} nurse.");
        }

        public void visit(Patient patient)
        {
            Console.WriteLine($"Tax Officer inspects {patient.Id} - {patient.Name} patient.");
        }
    }
}
