using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class CommercialPolicy
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        // action property added
        public bool IsActive { get; set; }
    }
}
