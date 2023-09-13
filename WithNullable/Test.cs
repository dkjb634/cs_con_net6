using System.Collections;

namespace WithNullable
{
#nullable enable

    using System.Diagnostics.CodeAnalysis;

    public class C
    {
        public void Usage(IList? list)
        {
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
        public static bool IsNullOrZero([NotNullWhen(false)] this IList? input)
        {
            return input == null || input.Count == 0;
        }
    }

#nullable disable
}