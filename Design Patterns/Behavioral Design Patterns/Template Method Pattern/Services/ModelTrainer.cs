

namespace Design_Patterns.Behavioral_Design_Patterns.Template_Method_Pattern.Services
{
    public abstract class ModelTrainer
    {
        public void Generate()
        {
            loadData();
            preprocessingData();
            trainModel();
            testModel();
            saveData();
        }

        public abstract void loadData();
        public abstract void preprocessingData();
        public abstract void trainModel();
        public abstract void testModel();

        /*----- this method unforce to modify-----*/
        public virtual void saveData()
        {
            Console.WriteLine("Initially save data.");
        }

    }
}
