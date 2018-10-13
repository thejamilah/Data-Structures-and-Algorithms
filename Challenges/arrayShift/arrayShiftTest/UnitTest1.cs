using System;
using Xunit;
using static arrayShift.Program;

namespace arrayShiftTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 8, 10, 12, 1}, new int[] { 8, 10, 9, 12, 1 })]
        [InlineData(new int[] { 15, 29, 35, 50}, new int[] { 15, 29, 9, 35, 50})]
        [InlineData(new int[] { 2, 4, 6, 8, 13}, new int[] { 2, 4, 6, 9, 8, 13})]
        public void CanInsert(int[] value, int[] expected )
        {
            //arrange
            int middleNum = 9;

            //act: call method that you want to test
            int[] result = ArrayShift(value, middleNum);

            //assert statement
            Assert.Equal(expected, result);


        }

        [Theory]
        [InlineData(7, new int[] { 8, 10, 7, 12, 1 })]
        [InlineData(21, new int[] { 8, 10, 21, 12, 1})]
        [InlineData(14, new int[] { 8, 10, 14, 12, 1})]
        public void CanInsertAnyMiddleNum(int middleNum, int[] expected)
        {
            //arrange
            int[] oldData = {8, 10, 12, 1};

            //act: call method that you want to test
            int[] result = ArrayShift(oldData, middleNum);

            //assert statement
            Assert.Equal(expected, result);


        }

    }
}
