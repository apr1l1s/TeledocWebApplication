namespace TeledocWebApplication.REST.Queries.ViewModels
{
    public class ClientViewModel
    {
        public Guid id { get; set; }
        public string inn { get; set; } = string.Empty;
        public string title { get; set; } = string.Empty;
        public bool statusType { get; set; } //ип 1 юр 0
        public DateTime creationDate { get; set; }
        public DateTime? editDate { get; set; }
    }
}
