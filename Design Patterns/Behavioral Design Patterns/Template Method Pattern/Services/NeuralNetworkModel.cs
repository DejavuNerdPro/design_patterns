

namespace Design_Patterns.Behavioral_Design_Patterns.Template_Method_Pattern.Services
{
    public class NeuralNetworkModel : ModelTrainer
    {
        public override void loadData()
        {
            Console.WriteLine("Load Data using CNN Model.");
        }

        public override void preprocessingData() => Console.WriteLine("Preprocess Data using CNN Model.");



        public override void testModel()
        => Console.WriteLine("Test Model using CNN Model.");

        public override void trainModel()
        => Console.WriteLine("Train Model using CNN Model.");
    }
}
