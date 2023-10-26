using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SofT_industries
{
    internal interface IUser
    {
        public int Id {  set; }
        public string Name {  set; }
        public string Login {  set; }
        public string Password {  set; }
    }
}
