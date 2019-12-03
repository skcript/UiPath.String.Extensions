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
    public class Capitalize : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> InputString { get; set; }

        [Category("Output")]
        [RequiredArgument]
        public OutArgument<string> Result { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string inputString = InputString.Get(context);

            var result = inputString.Capitalize();
            Result.Set(context, result);
        }
    }

}
