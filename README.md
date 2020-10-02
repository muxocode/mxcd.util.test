# mxcd.util.test

Util library for introspection test

## Example

Visit test folder for more examples

```csharp
using mxcd.util.test;
using System;
using Xunit;

namespace util.test.test
{
    public class CustomClassTest
    {
        Type type = typeof(clases.ok.CustomClass);

        [Fact]
        public void CheckDefaultConstructor()
        {
            Assert.True(type.Test().CheckDefaultConstructor());
        }

        [Fact]
        public void CheckHasAttributes()
        {
            Assert.True(type.Test().CheckHasAttributes());
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
```

<hr/>

Learn more in https://muxocode.com

<p align="center">
  <img src="https://muxocode.com/branding.png">
</p>