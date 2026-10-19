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
                // Menyn för programmet
                Menu.ShowMenu();

                // Läst in användarens val av menyalternativ och konverterat det till ett heltal och gör så att det inte kraschar om användaren skriver in något annat än ett heltal
                if (!int.TryParse(Console.ReadLine(), out int valAvMenyAlternativ))
                {
                    Console.WriteLine("Ogiltigt val, ange ett nummer.");
                    continue; 
                }

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
                    // Case 4 = Sortera ansökningar efter datum
                    case 4:
                        jobManager.SortByDate();
                        break;
                    // Case 5 = Visa statistik
                    case 5:
                        jobManager.ShowStatistics();
                        break;
                    // Case 6 = Uppdatera status på en ansökan
                    case 6:
                        jobManager.UpdateStatus();
                        break;
                    // Case 7 = Ta bort en ansökan
                    case 7:
                        jobManager.RemoveJob();
                        break;
                    // Case 8 = Avsluta programmet
                    case 8:
                        Console.WriteLine("Avslutar programmet...");
                        menynFortsätter = false;
                        break;
                    // Default case = Ogiltigt val
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }
        }
    }
}
