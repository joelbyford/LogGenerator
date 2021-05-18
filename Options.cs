using System;
using CommandLine;

namespace LogGenerator
{
    // Define a class to receive parsed values
    class Options 
    {
        [Option('e', "error", Required = false, HelpText = "Throws an ERROR with the included 'Text'")]
        public string ErrorMessage { get; set; }

        [Option('w', "warning", Required = false, HelpText = "Throws a WARNING with the included 'Text'")]
        public string WarningMessage { get; set; }
            
        [Option('n', "number", Default=1, HelpText = "The number of messages to generate (max of 100).")]
        public int NumberOfMessages { get; set; }


    }
}
