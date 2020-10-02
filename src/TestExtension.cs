using System;

namespace mxcd.util.test
{
    public static class TestExtension
    {
        public static TestUtil Test(this Type type)
        {
            return new TestUtil(type);
        }
    }
}
