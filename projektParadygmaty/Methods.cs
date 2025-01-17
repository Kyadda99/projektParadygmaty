using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektParadygmaty
{
    public class Methods
    {
        public static void ReadTraining(Training training, int number)
        {
            string train = training.ReadTraining(number);

            if (train == null) { Console.WriteLine("Incorrect training number"); }
            else Console.WriteLine(train);

        }        
        
        public static void ReadRegime(Training training)
        {
            string[] train = training.ReadRegime();

            foreach (string excersise in train)
            {
                Console.WriteLine(excersise);
            }


        }



    }
}
