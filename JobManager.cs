namespace ConsoleApp1
{

    // skapat klassen JobManager
    public class JobManager
    {
        // Skapat en lista av JobApplication som heter Applications. Listan innehåller alla ansökningar som användaren har lagt till
        public List<JobApplication> Applications { get; set; } = new List<JobApplication>();

        // Skapat en metod som lägger till jobb ansökningar
        public void AddJob()
        {
            Console.WriteLine();
            Console.WriteLine("Lägg till ett jobb");

            Console.WriteLine("Ange företagets namn:");
            string companyName = Console.ReadLine()!;

            Console.WriteLine("Ange jobbtitel:");
            string positionTitle = Console.ReadLine()!;

            Console.WriteLine("Ange vad du förväntar dig att få i lön:");
            int SalaryExpectation = Convert.ToInt32(Console.ReadLine()!);

            Console.WriteLine("Ange vilket datum du ansöker om jobbet (yyyy-MM-dd):");
            string applicationDate = Console.ReadLine()!;

            Applications.Add(new JobApplication{CompanyName = companyName, PositionTitle = positionTitle, SalaryExpectation = SalaryExpectation, ApplicationDate = DateTime.Parse(applicationDate)});

            Console.WriteLine();

            Console.WriteLine($"Företag: {companyName}");
            Console.WriteLine($"Jobbtitel: {positionTitle}");
            Console.WriteLine($"Lön: {SalaryExpectation} kr");
            Console.WriteLine($"Ansökningsdatum: {applicationDate}");
            Console.WriteLine("Ansökan har lagts till.");
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            Console.Clear();
        }

        // Lagt till en metod som visar först om det finns ansökningar eller inte, om det finns ansökningar så loopar den igenom listan och skriver ut alla ansökningar
        public void ShowAll()
        {
            Console.WriteLine();

            if (Applications.Count == 0)
            {
                Console.WriteLine("No job applications found.");
            }
            else
            {
                foreach (var application in Applications)
                {
                    Console.WriteLine(application.GetSummary());
                }
            }
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            Console.Clear();
        }

        // Lagt till en metod som uppdaterar statusen på en ansökan
        public void UpdateStatus(JobApplication application, Status newStatus)
        {
            application.Status = newStatus;
        }
    }
}
