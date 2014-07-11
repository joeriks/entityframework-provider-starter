using Microsoft.Data.Entity;

namespace SampleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var db = new CustomContext())
            {
                db.Database.AsProviderDatabase().CreateStorage();
            }
        }
    }
}