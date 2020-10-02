using mxcd.util.test;
using System;
using Xunit;

namespace util.test.test
{

    public class EmptyClassTest
    {
        Type type = typeof(clases.ok.EmptyClass);

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
            Assert.False(type.Test().CheckHasProps());
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
