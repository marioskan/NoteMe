using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoteMe.Models
{
    public class Notes
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }
    }
}