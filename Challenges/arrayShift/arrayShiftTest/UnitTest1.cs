using System;
using Xunit;

namespace arrayShiftTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new decimal[] { 8, 10, 12, 1}, new decimal[] { 8, 10, 9, 12, 1 })]
        public void CanInsert(decimal[] value, decimal[] expected )
        {

        }
    }
}
