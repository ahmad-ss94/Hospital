namespace Hospital.Application.Results.Patient
{
    public class PatientStatisticsResult
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public decimal? AverageOfBills { get; set; }

        public decimal? AverageOfBillsOutliers { get; set; }
        public DateTime? The5RecordEntryOfPatient { get; set; }

        public string? MonthHighestNumberOfVisits { get; set; }
    }
}
