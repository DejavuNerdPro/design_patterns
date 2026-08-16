

using Design_Patterns.Behavioral_Design_Patterns.Visitor_Pattern.Services;

namespace Design_Patterns.Behavioral_Design_Patterns.Visitor_Pattern
{
    public class main
    {
        /*public static void Main(string[] args)
        {
            List<IEmployee> employees = new List<IEmployee>()
            {
                new Doctor("U Ba Kyaing","008979"),new Nurse("Daw Pa Pa Khin","000876"),
                new Patient("Khin Maung Thein", "976867"),new Doctor("U Tun Kyaing","008989"),
                new Nurse("Daw Nu Pu","000877"),new Patient("Ko Ko Lwin", "976887"),
                new Patient("Ma Su Kuu", "976967"),new Patient("Aye Win", "976000")
            };

            IVisitor healthInspector = new HealthInspectorVisitor();
            IVisitor taxOfficer = new TaxOfficerVisitor();
            IVisitor insuranceOfficer = new InsuranceOfficerVisitor();

            foreach(var employee in employees)
            {
                employee.accept(healthInspector);
                employee.accept(taxOfficer);
                employee.accept(insuranceOfficer);
            }
        }*/
    }
}
