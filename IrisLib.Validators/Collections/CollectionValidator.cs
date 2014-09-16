using IrisLib.Helpers.Members;
using IrisLib.Validators.Generics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisLib.Validators.Collections
{
    public class CollectionValidator : GenericValidator
    {
        public static bool IsEmpty(ICollection collection)
        {
            return collection == null || collection.Count == 0;
        }

        public static bool IsEmpty<T>(ICollection<T> collection)
        {
            return collection == null || collection.Count == 0;
        }

        public static bool IsEmpty<T>(T[] collection)
        {
            return collection == null || collection.Length == 0;
        }

        public static void NotEmpty(ICollection collection, string message)
        {
            if (collection == null)
            {
                throw new NullReferenceException(MemberHelper.GetNameParameter(() => collection + " - " + message));
            }
            if (IsEmpty(collection))
            {
                throw new ArgumentException(MemberHelper.GetNameParameter(() => collection), message);
            }
        }

        public static void NotEmpty(ICollection collection)
        {
            NotEmpty(collection, string.Empty);
        }

        public static void NotEmpty<T>(T[] collection, string message)
        {
            if (collection == null)
            {
                throw new NullReferenceException(MemberHelper.GetNameParameter(() => collection + " - " + message));
            }
            if (IsEmpty(collection))
            {
                throw new ArgumentException(MemberHelper.GetNameParameter(() => collection), message);
            }
        }

        public static void NotEmpty<T>(T[] collection)
        {
            NotEmpty(collection, string.Empty);
        }

        public static void NotEmpty<T>(ICollection<T> collection, string message)
        {
            if (collection == null)
            {
                throw new NullReferenceException(MemberHelper.GetNameParameter(() => collection + " - " + message));
            }
            if (IsEmpty(collection))
            {
                throw new ArgumentException(MemberHelper.GetNameParameter(() => collection), message);
            }
        }

        public static void NotEmpty<T>(ICollection<T> collection)
        {
            NotEmpty(collection, string.Empty);
        }

        public static void NotNullElements(ICollection collection, string message)
        {
            NotNull(collection, message);

            foreach (var item in collection)
            {
                if (item == null)
                {
                    throw new ArgumentException(MemberHelper.GetNameParameter(() => item), message);
                }
            }
        }

        public static void NotNullElements(ICollection collection)
        {
            NotNullElements(collection, string.Empty);
        }

        public static void NotNullElements<T>(ICollection<T> collection, string message)
        {
            NotNull(collection, message);

            foreach (var item in collection)
            {
                if (item.Equals(null))
                {
                    throw new ArgumentException(MemberHelper.GetNameParameter(() => item), message);
                }
            }
        }

        public static void NotNullElements<T>(ICollection<T> collection)
        {
            NotNullElements(collection, string.Empty);
        }

        public static void NotNullElements<T>(T[] collection, string message)
        {
            NotNull(collection, message);

            foreach (var item in collection)
            {
                if (item.Equals(null))
                {
                    throw new ArgumentException(MemberHelper.GetNameParameter(() => item), message);
                }
            }
        }

        public static void NotNullElements<T>(T[] collection)
        {
            NotNullElements(collection, string.Empty);
        }
    }
}
