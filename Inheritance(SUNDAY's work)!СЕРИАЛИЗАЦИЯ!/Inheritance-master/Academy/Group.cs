using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    [Serializable]
    class Group
    {
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }
        public List<Graduate> Graduates { get; set; }

        public Group()
        {
            Teachers = new List<Teacher>();
            Students = new List<Student>();
            Graduates = new List<Graduate>();
        }


    }
}
