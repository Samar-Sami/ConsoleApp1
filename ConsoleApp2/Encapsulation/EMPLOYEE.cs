using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo.Encapsulation
{
    internal struct EMPLOYEE
    {




        public EMPLOYEE(int id, string? name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public EMPLOYEE(int id)
        {
            Id = id;
            Name = "name";
            Price = 12.2m;
        }

        public override string ToString()
        {
            return $"{Id} {Price}  {Name}";
        }




        int Id;
        string? Name;
        decimal Price;


        //getter
        public string? GetName ()
            { return Name; }


        //setter
       public void SetName(string? name)
        { Name = name; }

        //getter
        public int GetId()
        { return Id; }


        //setter
        public void SetId(int id)
        { this.Id = id; }



       

    }
}
