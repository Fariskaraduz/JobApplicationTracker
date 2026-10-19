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

            // Lagt till en ny ansökan i listan med ansökningar. Den nya ansökan innehåller företagets namn, jobbtitel, löneförväntning och ansökningsdatum.
            Applications.Add(new JobApplication{CompanyName = companyName, PositionTitle = positionTitle, SalaryExpectation = SalaryExpectation, ApplicationDate = DateTime.Parse(applicationDate)});

            Console.WriteLine();

            // Skriver ut information om den nya ansökan som har lagts till
            Console.WriteLine($"Företag: {companyName}");
            Console.WriteLine($"Jobbtitel: {positionTitle}");
            Console.WriteLine($"Lön: {SalaryExpectation} kr");
            Console.WriteLine($"Ansökningsdatum: {applicationDate}");
            Console.WriteLine("Ansökan har lagts till.");

            // Väntar på en tangent innan konsolen rensas
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            Console.Clear();
        }

        // Lagt till en metod som visar först om det finns ansökningar eller inte, om det finns ansökningar så loopar den igenom listan och skriver ut alla ansökningar
        public void ShowAll()
        {
            Console.WriteLine();
            // Kontrollerar om några ansökningar hittades
            if (Applications.Count == 0)
            {
                Console.WriteLine("No job applications found.");
            }
            else
            {
                // Loopar igenom listan och skriver ut alla ansökningar
                foreach (var application in Applications)
                {
                    Console.WriteLine(application.GetSummary());
                }
            }
            // Väntar på en tangent innan konsolen rensas
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            Console.Clear();
        }

        // Lagt till en metod som uppdaterar statusen på en ansökan
        public void UpdateStatus(JobApplication application, Status newStatus)
        {
            application.Status = newStatus;
        }

        // Lagt till en metod som filtrerar ansökningar efter status. Den frågar användaren vilken status de vill filtrera och skriver sedan ut alla ansökningar som matchar den statusen.
        public void FilterByStatus()
        {
            Console.WriteLine();
            Console.WriteLine("Välj vilket status du vill filtrera efter:");
            Console.WriteLine("1. Applied");
            Console.WriteLine("2. Interview");
            Console.WriteLine("3. Offer");
            Console.WriteLine("4. Rejected");

            // Läser in användarens val och converterar det till en string
            int valdAvStatusFiltrera = Convert.ToInt32(Console.ReadLine()!);

            // Hanterar användarens val av status
            switch (valdAvStatusFiltrera)
            {
                case 1:

                    // Filtrerar fram ansökningar med status Applied
                    var appliedApplications = Applications.Where(a => a.Status == Status.Applied).ToList();

                    // Kontrollerar om några ansökningar hittades
                    if (appliedApplications.Count == 0)
                    {
                        Console.WriteLine("Inga ansökningar med status 'Applied' hittades.");
                    }

                    // Visar alla ansökningar som matchar statusen
                    foreach (var application in appliedApplications)
                    {
                        Console.WriteLine(application.GetSummary());
                    }

                    break;

                case 2:

                    // Filtrerar fram ansökningar med status Interview
                    var interviewApplications = Applications.Where(a => a.Status == Status.Interview).ToList();

                    // Kontrollerar om några ansökningar hittades
                    if (interviewApplications.Count == 0)
                    {
                        Console.WriteLine("Inga ansökningar med status 'Interview' hittades.");
                    }

                    // Visar alla ansökningar som matchar statusen
                    foreach (var application in interviewApplications)
                    {
                        Console.WriteLine(application.GetSummary());
                    }
                    break;

                case 3:

                    // Filtrerar fram ansökningar med status Offer
                    var offerApplications = Applications.Where(a => a.Status == Status.Offer).ToList();

                    // Kontrollerar om några ansökningar hittades
                    if (offerApplications.Count == 0)
                    {
                        Console.WriteLine("Inga ansökningar med status 'Offer' hittades.");
                    }

                    // Visar alla ansökningar som matchar statusen
                    foreach (var application in offerApplications)
                    {
                        Console.WriteLine(application.GetSummary());
                    }
                    break;

                case 4:

                    // Filtrerar fram ansökningar med status Rejected
                    var rejectedApplications = Applications.Where(a => a.Status == Status.Rejected).ToList();

                    // Kontrollerar om några ansökningar hittades
                    if (rejectedApplications.Count == 0)
                    {
                        Console.WriteLine("Inga ansökningar med status 'Rejected' hittades.");
                    }

                    // Visar alla ansökningar som matchar statusen
                    foreach (var application in rejectedApplications)
                    {
                        Console.WriteLine(application.GetSummary());
                    }
                    break;

                default:
                    // Hanterar ett val som inte finns
                    Console.WriteLine("Ogiltigt val. Vänligen försök igen.");
                    break;
            }

            // Väntar på en tangent innan konsolen rensas
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            Console.Clear();
        }

        // Lagt till en metod som sorterar ansökningar efter datum. Den sorterar listan med ansökningar i stigande ordning efter ansökningsdatum.
        public void SortByDate()
        {
            // Om det inte finns några ansökningar i listan så skriver den ut ett meddelande och returnerar
            if (Applications.Count == 0)
            {
                Console.WriteLine("Inga ansökningar att sortera.");
                Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            // Sorterar ansökningarna efter ansökningsdatum i stigande ordning
            Applications = Applications.OrderBy(a => a.ApplicationDate).ToList();
            Console.WriteLine();
            Console.WriteLine("Ansökningar har sorterats efter ansökningsdatum.");

            // Loopar igenom listan och skriver ut alla ansökningar
            foreach (var application in Applications)
            {
                Console.WriteLine(application.GetSummary());
            }

            // Väntar på en tangent innan konsolen rensas
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            Console.Clear();
        }

        // Lagt till en metod som visar statestik
        public void ShowStatistics()
        {
            // Skriver ut statistik om ansökningarna
            Console.WriteLine();
            Console.WriteLine("Visa statistik");
            Console.WriteLine($"Totalt antal ansökningar: {Applications.Count}");
            Console.WriteLine($"Antal ansökningar med status 'Applied': {Applications.Count(a => a.Status == Status.Applied)}");
            Console.WriteLine($"Antal ansökningar med status 'Interview': {Applications.Count(a => a.Status == Status.Interview)}");
            Console.WriteLine($"Antal ansökningar med status 'Offer': {Applications.Count(a => a.Status == Status.Offer)}");
            Console.WriteLine($"Antal ansökningar med status 'Rejected': {Applications.Count(a => a.Status == Status.Rejected)}");

            // Väntar på en tangent innan konsolen rensas
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            Console.Clear();    
        }


    }
}
