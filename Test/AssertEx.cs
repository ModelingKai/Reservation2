
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test
{
    public static class AssertEx
    {
        public static void Fail()
        {
            true.Is(false);
        }
    }
}
