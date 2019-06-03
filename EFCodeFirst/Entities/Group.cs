using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Entities
{
   public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}




