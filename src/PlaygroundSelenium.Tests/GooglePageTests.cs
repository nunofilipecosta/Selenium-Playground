namespace PlaygroundSelenium.Tests
{
    using System;
    using Framework;
    using Xunit;

    public class GooglePageTests : IDisposable
    {
        public GooglePageTests()
        {
            Driver.Initialize();
        }

        [Fact]
        public void TestMethod()
        {
            var c = new GooglePage();
            c.Go();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Driver.Close();
        }
    }
}
