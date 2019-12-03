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
    public class AppendSuffixIfMissing : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> InputString { get; set; }

        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> SuffixString { get; set; }

        [Category("Input")]
        public InArgument<bool> IgnoreCase { get; set; }

        [Category("Output")]
        [RequiredArgument]
        public OutArgument<string> Result { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string inputString = InputString.Get(context);
            string suffixString = SuffixString.Get(context);
            bool ignoreCase = IgnoreCase.Get(context);

            var result = inputString.AppendSuffixIfMissing(suffixString, ignoreCase);
            Result.Set(context, result);
        }
    }

}
