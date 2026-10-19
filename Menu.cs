namespace ConsoleApp1
{
    // Skapat en klass som heter Menu
    public class Menu
    {
        // Skapat en metod som visar menyn
        public static void ShowMenu()
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
        }
    }
}
