using System;
using CommandLine;
using System.Diagnostics.Tracing;

namespace LogGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed<Options>(o =>
                   {
                       // Generate the number of errors requested
                       for(int i=0; i<= o.NumberOfMessages; i++)
                       {
                           // Error if selected
                            if (o.ErrorMessage != null)
                            {
                                Logger.Log.LogError(o.ErrorMessage);
                                Console.WriteLine($"Error - Current Arguments: -e {o.ErrorMessage}");
                            }
                            
                            if (o.WarningMessage != null)
                            {
                                Logger.Log.LogWarning(o.WarningMessage);
                                Console.WriteLine($"Warning - Current Arguments: -w {o.WarningMessage}");
                            }
                       }
                   });
            
        }


        
    }
}
