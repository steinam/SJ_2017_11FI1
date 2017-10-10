using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Stacker;

namespace TestStacker
{
    
    [TestFixture]
    class TestStacker
    {
        private StackClass myStack;

        [SetUp]
        public void Init()
        {
            StackClass myStack = new StackClass();
        }

        // T1: Create a Stack and verify that IsEmpty is true.

        [Test]
        public void IsEmptyIsTrue()
        {
            StackClass myStack = new StackClass();
            Assert.IsTrue(myStack.IsEmpty);
        }

        //T2: Push a single object on the Stack and verify that IsEmpty is false.

        [Test]
        public void PushOne()
        {
            StackClass myStack = new StackClass();
            myStack.Push("my first element");
            Assert.IsFalse(myStack.IsEmpty, "IsEmpty muss falsch sein");
        }

        //T3: Push a single object, Pop the object, and verify that IsEmpty is true.

        [Test]
        public void PopOne()
        {
            StackClass myStack = new StackClass();
            myStack.Push("my first element");
            myStack.Pop();
            Assert.IsTrue(myStack.IsEmpty);
        }

        //T4: Push a single object, remembering what it is; Pop the object, and verify that the two objects are equal.

        [Test]
        public void PushPopContentEqual()
        {
            int WasIchHabe = 1234;
            myStack.Push(WasIchHabe);

            int WasIchBekomme = (int)myStack.Pop();
            Assert.AreEqual(WasIchHabe, WasIchBekomme);
        }
    }
}
