using ParseXmlSaveIntoDatabase.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ParseXmlSaveIntoDatabase
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            XElement xelement = XElement.Load(@"C:\Users\Umar\Desktop\sample.xml");
            IEnumerable<XElement> parseResult = xelement.Elements();
             Crud_DatabaseEntities1 gyt = new Crud_DatabaseEntities1();
            //Iterate and Save Into Database
            foreach (var item in parseResult)
            {

                System.Console.WriteLine("Item Id : {0} ,Item Name : {1}, Item Sex : {2}, Item Phone : {3}",
                    item.Element("EmpId").Value, item.Element("Name").Value, item.Element("Sex").Value,
                    item.Element("Phone").Value
                    );
                //Save Into Database
                var message = new XmlParsing
                {
                    EmpId = Convert.ToInt64(item.Element("EmpId").Value),
                    Name = item.Element("Name").Value,
                    Sex = item.Element("Sex").Value,
                    Phone = item.Element("Phone").Value
                };


                gyt.XmlParsings.Add(message);
                gyt.SaveChanges();
            }
            
            Console.ReadKey();
        




        }
    }
}
