using mxcd.util.test;
using System;
using Xunit;

namespace util.test.test
{

    public class CustomClassNoAttrTest
    {
        Type type = typeof(clases.ok.CustomClassNoAttr);

        [Fact]
        public void CheckDefaultConstructor()
        {
            Assert.True(type.Test().CheckDefaultConstructor());
        }

        [Fact]
        public void CheckHasAttributes()
        {
            Assert.False(type.Test().CheckHasAttributes());
        }

        [Fact]
        public void CheckHasProps()
        {
            Assert.True(type.Test().CheckHasProps());
        }

        [Fact]
        public void CheckNameAttributes()
        {
            Assert.True(type.Test().CheckNameAttributes());
        }

        [Fact]
        public void CheckNameMethods()
        {
            Assert.True(type.Test().CheckNameMethods());
        }

        [Fact]
        public void CheckNameProps()
        {
            Assert.True(type.Test().CheckNameProps());
        }
    }
}
