using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI2.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Body { get; set; }

        public DateTime CreteDate { get; set; }

        public DateTime? ChangeDate { get; set; }
    }
}
