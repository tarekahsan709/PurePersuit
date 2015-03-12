using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Person
    {
        private string name;
        private string number;
        private string id;
        public int i = 0;
        //private string[] phoneNumber = new string[50];
        public List<string> phoneNumber = new List<string>();


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        //public void setNumber(List<string> list)
        //{
        //    this.phoneNumber=
        //}
        //public string[] PhoneNumber
        //{
        //    get { return this.phoneNumber; }
        //}


        //public void setNumber(string num)
        //{
        //    this.phoneNumber[i] = num;
        //    i++;
        //}
        //public string[] getNumber()
        //{
        //    return this.phoneNumber;
        //}




    }

}
