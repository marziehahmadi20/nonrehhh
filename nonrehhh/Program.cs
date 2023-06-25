using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace nonrehhh
{
    internal class karname
    {
        private string id;
        private string name;
        private string family;
        private double nomre;
        public double Nomre
        {
            get { return nomre; }
            set { nomre = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name= value; }
        }
        public string Family
        {
            get { return family; }
            set { family = value; }
        }
        public karname() { }
        public karname(string Id, string Name, string Family, double Nomre) {
            Nomre = nomre;
            Name = name;
            Id = id;
            Family = family;
        }
        public void calc(string id, string name, string family, double nomre)
        {
           if (nomre <= 10)
            {
               Console.WriteLine("Pass");
            }
           else if(nomre >= 10)
            {
                Console.WriteLine("hazf");
            }
           else if(nomre == 0)
            {
                Console.WriteLine("eror");
            }
        }
        static void Main(string[] args)
        {
            string id = Convert.ToString(Console.ReadLine());
            string name = Convert.ToString(Console.ReadLine());
            string family = Convert.ToString(Console.ReadLine());
            double nomre = Convert.ToDouble(Console.ReadLine());
            karname ts = new karname() ;
            ts.calc();
 
        }
    }
}
