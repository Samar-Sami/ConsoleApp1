using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Person
    {
        #region property
        public string Name { get; set; }
        public int Age { get; set; }
        #endregion

        #region methods
     
        public override string ToString()
        {
            return $"Name : {Name}  , Age :{Age}";
        } 
        #endregion
    }
}
