using IrisLib.Helpers.Members;
using IrisLib.Validators.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisLib.Validators.Booleans
{
    public class BooleanValidator : GenericValidator
    {
        public static void IsTrue(bool input, string message)
        {
            if (input == false)
            {
                throw new ArgumentException(MemberHelper.GetNameParameter(() => input), message);
            }
        }

        public static void IsTrue(bool input)
        {
            IsTrue(input, string.Empty);
        }
    }
}
