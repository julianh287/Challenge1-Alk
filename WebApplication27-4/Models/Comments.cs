using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication27_4.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public Usuario Usuario { get; set; }
        public Post Post { get; set; }
    }
}
