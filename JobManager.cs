namespace ConsoleApp1
{

    // skapat klassen JobManager
    public class JobManager
    {
        // Skapat en lista av JobApplication som heter Applications. Listan innehåller alla ansökningar som användaren har lagt till
        public List<JobApplication> Applications { get; set; } = new List<JobApplication>();

        // Skapat en metod som lägger till jobb ansökningar
        public void AddJob(JobApplication application)
        {
            Applications.Add(application);
        }

        // Lagt till en metod som visar först om det finns ansökningar eller inte, om det finns ansökningar så loopar den igenom listan och skriver ut alla ansökningar
        public void ShowAll()
        {

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
        }

        public void UpdateStatus(JobApplication application, Status newStatus)
        {
            application.Status = newStatus;
        }
    }
}
