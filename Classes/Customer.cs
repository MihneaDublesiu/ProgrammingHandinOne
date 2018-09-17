using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRetrieval
{
    public class Customer
    {
        public string Name; 
        public int Age; 
        public int Zip; 
        public string Password; 

       public Customer()
        {

        }

        public Customer (string name)
            
        {
            this.Name = name; 
        }

        public Customer (string name, int age)
          
        {
            this.Name = name;
            this.Age = age;
        }

        public Customer (string name, int age, int zip)
             
        {
            this.Name = name;
            this.Age = age;
            this.Zip = zip;
        }

        public Customer (string name, int age, int zip, string password)
        {
            this.Name = name;
            this.Age = age;
            this.Zip = zip;
            this.Password = password;
        }  
        
            

        public override string ToString()
        {
            return "\nName:" + Name + " \nAge: " + Age + " \nZip Code: " + Zip + " \nPassword: " + Password + "\n";
        }

    }
}
