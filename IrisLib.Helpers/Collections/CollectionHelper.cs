using IrisLib.Validators.Generics;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace IrisLib.Helpers.Collections
{
    public class CollectionHelper
    {               
        public static ICollection Subtract(ICollection a, ICollection b)
        {
            GenericValidator.NotNull(a, "The parameter a is null");
            GenericValidator.NotNull(b, "The parameter b is null");

            var result = new ArrayList(a);

            foreach (var item in b)
            {
                result.Remove(item);
            }

            return result;
        }

        public static ICollection<T> Subtract<T>(ICollection<T> a, ICollection<T> b)
        {
            GenericValidator.NotNull(a, "The parameter a is null");
            GenericValidator.NotNull(b, "The parameter b is null");

            var result = new List<T>(a);

            foreach (var item in b)
            {
                result.Remove(item);
            }

            return result;
        }

        public static T[] Subtract<T>(T[] a, T[] b)
        {
            GenericValidator.NotNull(a, "The parameter a is null");
            GenericValidator.NotNull(b, "The parameter b is null");

            var result = new List<T>();

            foreach (var item in b)
            {
                result.Remove(item);
            }

            return result.ToArray();
        }
    }
}
