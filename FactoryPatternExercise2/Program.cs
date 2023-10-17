namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of Database do you want to access? You can create a data access for List, Mongo, or SQL.");
            string userInput = Console.ReadLine().ToLower();

           IDataAcces dataAccessType = DataAccessFactory.GetDataAcessType(userInput);
        }
    }
}
