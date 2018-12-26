using System;
using Xunit;
using Hashtables.Classes;

namespace HashtableTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddKeyValuePairToHashtable()
        {
            MyHashTable hash = new MyHashTable();
            hash.Add(5, "naming");
            hash.Add(7, "conventions");
            hash.Add(9, "destroy");
            hash.Add(21, "time");

            int findValue = hash.FindKey("destroy");
            Assert.Equal(9, findValue);

        }

        [Fact]
        public void CanContainValue()
        {
            MyHashTable hash = new MyHashTable();
            hash.Add(5, "naming");
            hash.Add(7, "conventions");
            hash.Add(8, "always");
            hash.Add(9, "destroy");
            hash.Add(21, "time");

            Assert.True(hash.Contains("always"));
        }

        [Fact]
        public void CanFindKey()
        {
            MyHashTable hash = new MyHashTable();
            hash.Add(5, "missing");
            hash.Add(7, "curly");
            hash.Add(8, "braces");
            hash.Add(9, "make");
            hash.Add(21, "you");
            hash.Add(27, "cry");

            int findValue = hash.FindKey("cry");

            Assert.Equal(27, findValue);

        }

        [Fact]
        public void CanHandleCollision()
        {
            MyHashTable hash = new MyHashTable();
            hash.Add(5, "olive");
            hash.Add(7, "ilove");
            hash.Add(8, "evian");
            hash.Add(22, "olive");
            hash.Add(9, "niave");

            int findValue = hash.FindKey("olive");

            Assert.Equal(5, findValue);
        }
    }
}
