namespace ConsoleApp1
{
    // Ett Enum som beskriver dem olika statusarna en jobbasnsökan kan ha
    public enum Status
    {
        Applied,
        Interview,
        Offer,
        Rejected
    }

    // Skapat en klass som heter JobApplication
    public class JobApplication
    {

        // Attribut/properties för ansökan
        public string CompanyName { get; set; }
        public string PositionTitle { get; set; }
        public int SalaryExpectation { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime? ResponseDate { get; set; }
        public Status Status { get; set; }


        // En metod som returerar antal dagar sedan ansökan skickades
        public int GetDaysSinceApplied()
        {
            DateTime currentDate = DateTime.Now;
            return (currentDate - ApplicationDate).Days;
        }

        // En metod som kort sammanfattar olika ansökan som text

        public string GetSummary()
        {
            return $"Company: {CompanyName}\n" +
                   $"Position: {PositionTitle}\n" +
                   $"Salary Expectation: {SalaryExpectation} kr\n" +
                   $"Application Date: {ApplicationDate.ToShortDateString()}\n" +
                   $"Response Date: {(ResponseDate.HasValue ? ResponseDate.Value.ToShortDateString() : "N/A")}\n" +
                   $"Status: {Status}";
        }

    }
}
