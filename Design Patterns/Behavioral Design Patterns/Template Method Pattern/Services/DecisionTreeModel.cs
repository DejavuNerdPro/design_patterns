

namespace Design_Patterns.Behavioral_Design_Patterns.Template_Method_Pattern.Services
{
    public class DecisionTreeModel : ModelTrainer
    {
        public override void loadData()
        {
            Console.WriteLine("Load Data using Decision Tree Model.");
        }

        public override void preprocessingData()
        {
            Console.WriteLine("Preprocess Data using Decision Tree Model.");
        }

        public override void testModel()
        {
            Console.WriteLine("Test Model using Decision Tree Model.");
        }

        public override void trainModel()
        {
            Console.WriteLine("Train Model using Descision Tree Model");
        }

        public override void saveData()
        {
            Console.WriteLine("Save Data using Decision Tree Model");
        }
    }
}
