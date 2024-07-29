using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeledocWebApplication.Core.Model
{
    public class Founder
    {
        [Key]
        public Guid id { get; set; }
        public string inn { get; set; } = string.Empty;
        public string surname { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public string middlename { get; set; } = string.Empty;
        public DateTime creationDate { get; set; }
        public DateTime? editDate { get; set; }
        //Внешний ключ
        public Guid? clientId { get; set; }
        //Навигационное свойство
        public Client? client { get; set; }

    }
}
