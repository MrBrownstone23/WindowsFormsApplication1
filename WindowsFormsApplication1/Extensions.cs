using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class Extensions
    {
        public static T[] ToWrappedArray<T>(this T source)
        {
            if (source == null)
                return new T[] { };
            return new[] { source };
        }
        public static async Task<TValue> UnWrapSingleValue<TKey, TValue>(this Task<IDictionary<TKey, TValue>> task)
        {
            var dict = await task;
            return dict.Any() ? dict.First().Value : default(TValue);
        }





        public static IEnumerable<long> ToInt64List(this string obj, bool returnNullable)
        {
            if (obj == "" || obj == null)
                return Enumerable.Empty<long>();

            // The ";" are to keep objects grouped on grids where one checkbox can represent multiple objectsfor grids where one object. When the desired result is to obtain all of the objects without the grouping, they have to be replaced with ",".
            return obj.Replace(';', ',').Split(',').Select(x => x.ToInt64() ?? 0).Where(x => x != 0);
        }

        public static Int64? ToInt64(this string obj)
        {
            long value;
            if (obj != null && long.TryParse(obj, out value))
                return value;
            else
                return null;
        }

        public static Int32? ToInt32(this string obj)
        {
            int value;
            if (obj != null && int.TryParse(obj, out value))
                return value;
            else
                return null;
        }

    }
}
