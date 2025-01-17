using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektParadygmaty
{
    public class Excersise
    {
        public string name {  get; set; }
        public string description {  get; set; }
        public int numberOfRepetes {  get; set; }
        public int secondsOfBrake {  get; set; }

        public Excersise(string name, string description, int numberOfRepetes, int secondsOfBrake)
        {
            this.name = name;
            this.description = description;
            this.numberOfRepetes = numberOfRepetes;
            this.secondsOfBrake = secondsOfBrake;
        }

        public Excersise()
        {
        }

        public string ReadEXcersise()
        {
            return "Name: " + name + "\nDescription: " + description + "\nNumberOfRepetes: " + numberOfRepetes +"\nBreak: " + secondsOfBrake + " seconds\n";
        }

    }
}
