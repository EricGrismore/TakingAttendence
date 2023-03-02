using System;
using System.Net.NetworkInformation;

namespace Employees
{
    interface Substitute
    {
        public int NStudent { get; set; }
        public string TFirstN { get; set; }
        public string TLastN { get; set; }
        public string Fullname();
    }
    class Program
    {
        class Today : Substitute
        {
            public int NStudent { get; set; }
            public string TFirstN { get; set; }
            public string TLastN { get; set; }
            public string Subject { get; set; }
            public int ClassroomN { get; set; }

            public Today()
            {
                NStudent = 0;
                TFirstN = string.Empty;
                TLastN = string.Empty;
                Subject = string.Empty;
                ClassroomN = 0;

            }
            public Today(int Nstudent, string TfirstN, string TlastN, string subject, int classroomN)
            {
                NStudent = Nstudent;
                TFirstN = TfirstN;
                TLastN = TlastN;
                Subject = subject;
                ClassroomN = classroomN;
            }
            public string Fullname()
            {
                return TFirstN + "" + TLastN;
            }
            public string Details()
            {
                return NStudent + " " + Subject + " " + ClassroomN;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Substitutes For today: Details-");


                Today griffin = new Today(12, "Griffin ", "Mallus ", "Economics ", 134);
                Console.WriteLine(griffin.Fullname());
                Console.WriteLine(griffin.Details());

                Console.WriteLine("-----------------------------------------------------------");

                Today freddy = new Today(35, "Freddy ", "Tyrone ", "Mathmatics ", 153);
                Console.WriteLine(freddy.Fullname());
                Console.WriteLine(freddy.Details());

                Console.WriteLine("------------------------------------------------------------");

                Today Pete = new Today();
                Pete.NStudent = 20;
                Pete.TFirstN = "Pete ";
                Pete.TLastN = "Yamar ";
                Pete.Subject = "Social Science ";
                Pete.ClassroomN = 125;
                Console.WriteLine(Pete.Fullname());
                Console.WriteLine(Pete.Details());

            }
        }

    }


}
