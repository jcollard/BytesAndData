namespace FiveTwoOneOneDecoder
{
    using System;

    /// <summary>
    /// The Driver class contains the Main method to the program. This is the
    /// EntryPoint that is used when the project is run.
    /// </summary>
    public class Driver
    {
        /// <summary>
        /// This is the Main method (procedure) which is the Entry Point for the
        /// project. When you run the project, code begins executing from the
        /// first line.
        /// </summary>
        public static void Main()
        {
            IFiveTwoOneOneDecoder decoder = new Config().GetDecoder();
            byte encoding = 0b0000_0001;
            string color = decoder.DecodeColor(encoding);
            Console.WriteLine(color);
            string value = decoder.DecodeValue(encoding);
            Console.WriteLine(value);
            Console.WriteLine(color + " " + value);
            Console.WriteLine($"{color} {value}");
        }
    }
}