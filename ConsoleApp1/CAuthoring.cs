using System.Collections;

namespace ConsoleApp1
{
#nullable disable

    using JetBrains.Annotations;

    public class C
    {
        public void Usage([CanBeNull] IList list)
        {//TODO: first last
            if (list.IsNullOrZero())
            {
                return;
            }

            for (var index = 0; index < list.Count; index++)
            {
                Console.WriteLine(list[index]);
            }
        }
    }

    public static class MyExtensions
    {
        [ContractAnnotation("null => false")]
        public static bool IsNullOrZero([CanBeNull] this IList input)
        {
            return input == null || input.Count == 0;
        }
    }
}