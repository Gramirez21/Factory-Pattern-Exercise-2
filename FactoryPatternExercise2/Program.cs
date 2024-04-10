namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select data server list, mongo or sql");
            string userinput = Console.ReadLine();

            var dataAccess = DataAccessFactory.DataAccess(userinput);
            dataAccess.LoadData();
            dataAccess.SaveData();
        }
    }
}
