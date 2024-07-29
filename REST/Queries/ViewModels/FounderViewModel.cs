using TeledocWebApplication.Core.Model;

namespace TeledocWebApplication.REST.Queries.ViewModels
{
    public class FounderViewModel
    {
        public Guid id { get; set; }
        public string inn { get; set; } = string.Empty;
        public string surname { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public string middlename { get; set; } = string.Empty;
        public DateTime creationDate { get; set; }
        public DateTime? editDate { get; set; }
        //Внешний ключ
        public Guid? clientId { get; set; }
    }
}
