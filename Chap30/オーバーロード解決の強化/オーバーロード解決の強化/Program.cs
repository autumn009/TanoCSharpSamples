using System.Threading.Tasks;

class Program
{
    static Task DoThings()
    {
        return Task.FromResult(0);
    }
    static void Main(string[] args)
    {
        Task.Run(DoThings);
    }
}
