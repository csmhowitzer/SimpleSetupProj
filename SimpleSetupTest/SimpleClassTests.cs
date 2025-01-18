using System;
using System.Diagnostics;
using System.Threading;
using Xunit;
using static Xunit.Assert;
using SimpleSetup;

namespace SimpleSetupTest
{
    public class SimpleSetupTests
    {
        [Fact(DisplayName = "Returns Hello")]
        public void ReturnsHello()
        {
            while(!Debugger.IsAttached) Thread.Sleep(500);
            Equal("dHello", new SimpleClass().Hello());
        }
    }
}
