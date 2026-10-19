namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapat ett objekt av JobManager-klassen
            JobManager jobManager = new JobManager();

            // Skapat en boolean variabel för att hålla reda på om menyn ska fortsätta visas
            bool menynFortsätter = true;

            // Skapat en while loop för att fortsätta visa menyn tills användaren väljer att avsluta
            while (menynFortsätter)
            {
                // Skriver ut menyn till konsolen
                Console.WriteLine("Välkommen till Job Application Tracker ");
                Console.WriteLine("1. Lägg till ny ansökan");
                Console.WriteLine("2. Visa alla ansökningar");
                Console.WriteLine("3. Filtrera ansökningar efter status");
                Console.WriteLine("4. Sortera ansökningar efter datum");
                Console.WriteLine("5. Visa statistik");
                Console.WriteLine("6. Uppdatera status på en ansökan");
                Console.WriteLine("7. Ta bort en ansökan");
                Console.WriteLine("8. Avsluta programmet");

                // Läser in användarens val från konsolen och konverterar det till en int
                int valAvMenyAlternativ = Convert.ToInt32(Console.ReadLine());

                // Skapat en switch case för att hantera användarens val av menyalternativ
                switch (valAvMenyAlternativ)
                {
                    // Case 1 = Lägg till ny ansökan
                    case 1:
                        jobManager.AddJob();
                        break;
                    // Case 2 = Visa alla ansökningar
                    case 2:
                        jobManager.ShowAll();
                        break;
                    // Case 3 = Filtrera ansökningar efter status
                    case 3:
                        jobManager.FilterByStatus();
                        break;
              
                }
            }
        }
    }
}
