using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodewarsBack.Models
{
    public class ReserveModel
    {
        public int Id { get; set; }
        public int CohortId { get; set; }
        
        public int KataId { get; set; }
        public string? CodewarsName { get; set; }
        public string? KataName { get; set; }
        public string? KataSlug { get; set; }
        public string? KataLink { get; set; }
        public string? KataLanguage { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsDeleted { get; set; }
    }
}