using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // {    2022. 11. 25    Add feature - User input / Beta
            string userInput = string.Empty;
            Console.WriteLine("This program convert Cm to Inch");
            Console.Write("Input Cm value : ");
            userInput = Console.ReadLine();

            int cmInput = 0;
            int.TryParse(userInput, out cmInput);

            Ruler ruler = new Ruler(cmInput);
            ruler.Run();
            // }    2022. 11. 25    Add feature - User input / Beta
        }
    }

    public class Ruler
    {
        private const float ONE_INCH = 2.54F;
        public int Centimeter { get; set; } = 0;

        // {    2022. 11. 25 Add function - private SetInch | Gamma
        public float Inch
        {
            get { return Centimeter * ONE_INCH; }
            private set { this._SetInch(value); }
        }
        public Ruler(int cmValue) { Centimeter = cmValue; }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm 는 {this.Inch}inch 입니다.");
        }

        private void _SetInch(float inchValue) 
        { 
            Centimeter = (int)(inchValue / ONE_INCH); 
        }
        // }    2022. 11. 25 Add function - private SetInch | Gamma
    }
}
