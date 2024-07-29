using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace TeledocWebApplication.Core.Model
{
    public class Client
    {
        [Key]
        public Guid id { get; set; }
        public string inn { get; set; } = string.Empty;
        public string title { get; set; } = string.Empty;
        public bool statusType { get; set; } //ип 1 юр 0
        public DateTime creationDate { get; set; }
        public DateTime? editDate { get; set; }
        public List<Founder> founders { get; set; } = new();

    }
}
