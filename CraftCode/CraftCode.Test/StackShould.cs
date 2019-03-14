using System;
using NUnit.Framework;

namespace CraftCode.Day1.Test
{
    public class StackShould
    {
        private static readonly object object1 = "Some Object";
        private static readonly object object2 = "Another object";
        private Stack stack;

        [SetUp]
        public void Initialize()
        {
            stack = new Stack();
        }

        [Test]
        public void Throw_An_Exception_If_Popped_When_Empty()
        {
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void Pop_The_Last_Pushed_Element()
        {
            stack.Push(object1);

            Assert.AreEqual(object1.GetHashCode(), stack.Pop().GetHashCode());
        }

        [Test]
        public void Pop_Multiple_Objects_And_Check_The_Order()
        {
            stack.Push(object1);
            stack.Push(object2);

            Assert.AreEqual(object2.GetHashCode(), stack.Pop().GetHashCode());
            Assert.AreEqual(object1.GetHashCode(), stack.Pop().GetHashCode());
        }
    }
}