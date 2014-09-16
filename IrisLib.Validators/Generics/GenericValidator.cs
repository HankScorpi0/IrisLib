using IrisLib.Helpers.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisLib.Validators.Generics
{
    public class GenericValidator
    {
        public static void NotNull(object entity)
        {
            NotNull(entity, string.Empty);
        }

        public static void NotNull(object entity, string message)
        {
            if (entity == null)
            {
                throw new ArgumentException(MemberHelper.GetNameParameter(() => entity), message);
            }
        }
    }
}
