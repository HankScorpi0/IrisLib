using IrisLib.Helpers.Members;
using IrisLib.Validators.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisLib.Validators.Strings
{
    public class StringValidator : GenericValidator
    {
        public static bool IsBlank(string entity)
        {
            return entity == null || entity.Equals(string.Empty);
        }

        public static void NotBlank(string entity, string message)
        {
            if (entity == null)
            {
                throw new NullReferenceException(MemberHelper.GetNameParameter(() => entity + " - " + message));
            }
            if (IsBlank(entity))
            {
                throw new ArgumentException(MemberHelper.GetNameParameter(() => entity), message);
            }
        }

        public static void NotBlank(string entity)
        {
            NotBlank(entity, string.Empty);
        }
    }
}
