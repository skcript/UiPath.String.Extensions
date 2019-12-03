using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringExtensionLibrary;


namespace UiPath.String.Extensions
{
    public class CountOccurrences : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> InputString { get; set; }


        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> SubStringToCheck { get; set; }

        [Category("Output")]
        [RequiredArgument]
        public OutArgument<int> Result { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string inputString = InputString.Get(context);
            string subStringToCheck = SubStringToCheck.Get(context);

            var result = inputString.CountOccurrences(subStringToCheck);
            Result.Set(context, result);
        }
    }

}
