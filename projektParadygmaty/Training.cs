using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektParadygmaty
{
    public class Training
    {
        public Excersise[] Excersisees {  get; set; }

        public Training(Excersise[] excersisees)
        {
            Excersisees = excersisees;
        }

        public Training()
        {
        }

        public string[] ReadRegime()
        {
            int length = Excersisees.Length;

            string[] regime = new string[length];
            int j = 0;
            foreach (var i in Excersisees)
            {
                regime[j] = i.ReadEXcersise()+"\n";
                j += 1;
            }
            return regime;
        }


        public string ReadTraining(int number = 0)
        {
            if (number > Excersisees.Length | number < 0) return null;

            string[] regime = ReadRegime();

            string training = regime[number];


            return training;

        }


    }
}
