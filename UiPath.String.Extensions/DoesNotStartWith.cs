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
    public class DoesNotStartWith : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> InputString { get; set; }

        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> PrefixString { get; set; }

        [Category("Output")]
        [RequiredArgument]
        public OutArgument<bool> Result { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string inputString = InputString.Get(context);
            string prefixString = PrefixString.Get(context);

            var result = inputString.DoesNotStartWith(prefixString);
            Result.Set(context, result);
        }
    }

}
