using System;
using System.Activities;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringExtensionLibrary;


namespace UiPath.String.Extensions
{
    public class QueryStringToDictionary : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> InputString { get; set; }

        [Category("Output")]
        [RequiredArgument]
        public OutArgument<IDictionary> Result { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string inputString = InputString.Get(context);

            var result = inputString.QueryStringToDictionary();
            Result.Set(context, result);
        }
    }

}
