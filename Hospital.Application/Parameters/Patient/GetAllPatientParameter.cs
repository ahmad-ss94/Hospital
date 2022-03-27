namespace Hospital.Application.Parameters.Patient
{
    public class GetAllPatientParameter
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public GetAllPatientParameter()
        {
            PageNumber = 1;
            PageSize = 10;
        }
    }
}
