using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effay
{
    public class Attribute
    {
        public int attrib { get; set; }
        public float weight { get; set; }

        public Attribute(int attribute, float weight)
        {
            this.attrib = attribute;
            this.weight = weight;
        }
    }
}
