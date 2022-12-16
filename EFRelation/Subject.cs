using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace EFRelation
{
    public class Subject
    {
        [Key]
      
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int SubMaxMarks { get; set; }
        public string SubMarksObtained { get; set; }
        public int StudentId { get; set; }
        


    }
}
