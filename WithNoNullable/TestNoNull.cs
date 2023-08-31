using System.Collections;

namespace WithNoNullable
{
#nullable disable
    using JetBrains.Annotations;
    public class C
    {
        public void Usage([CanBeNull] IList list)
        {
            if (list.IsNullOrZero())
            {
                return;
            }

            for (var index = 0; index < list.Count; index++)
            {
                Console.WriteLine(list[index]);//////////////////////////////////?//////////////////////////////////?///////////////////////////////////////////////////////////////////////
            }
        }
    }

    public static class MyExtensions
    {
        [ContractAnnotation("null => true")]
        public static bool IsNullOrZero([CanBeNull] this IList input)
        {
            return input == null || input.Count == 0;
        }
    }
    #nullable enable
}