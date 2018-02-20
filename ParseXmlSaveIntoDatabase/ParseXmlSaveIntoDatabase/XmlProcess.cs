using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseXmlSaveIntoDatabase
{
    public class XmlProcess
    {
        
        public long Id { get; set; }
        public long? Employee_Id { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_Sex { get; set; }
        public string Employee_PhoneNo { get; set; }
    }
}
