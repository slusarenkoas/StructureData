namespace TestStructureData;

public class StackTest
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_EmptyStack_AddsValue()
        {
            var stack = new StructureData.Stack<int>();
            stack.Push(1);
            Assert.That(stack.Count, Is.EqualTo(1));
            if (stack.First != null) Assert.That(stack.First.Value, Is.EqualTo(1));
        }

        [Test]
        public void Push_NonEmptyStack_AddsValueOnTop()
        {
            var stack = new StructureData.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.That(stack.Count, Is.EqualTo(3));
            if (stack.First != null) Assert.That(stack.First.Value, Is.EqualTo(3));
        }

        [Test]
        public void Pop_EmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new StructureData.Stack<int>();
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void Pop_NonEmptyStack_RemovesAndReturnsTopValue()
        {
            var stack = new StructureData.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            var value = stack.Pop();
            Assert.Multiple(() =>
            {
                Assert.That(value, Is.EqualTo(3));
                Assert.That(stack.Count, Is.EqualTo(2));
            });
            if (stack.First != null) Assert.That(stack.First.Value, Is.EqualTo(2));
        }

        [Test]
        public void Peek_EmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new StructureData.Stack<int>();
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        [Test]
        public void Peek_NonEmptyStack_ReturnsTopValue()
        {
            var stack = new StructureData.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            var value = stack.Peek();
            Assert.Multiple(() =>
            {
                Assert.That(value, Is.EqualTo(3));
                Assert.That(stack.Count, Is.EqualTo(3));
            });
            if (stack.First != null) Assert.That(stack.First.Value, Is.EqualTo(3));
        }

        [Test]
        public void Clear_EmptyStack_ClearsStack()
        {
            var stack = new StructureData.Stack<int>();
            stack.Clear();
            Assert.That(stack.Count, Is.EqualTo(0));
            Assert.That(stack.First, Is.Null);
        }

        [Test]
        public void Contains_EmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new StructureData.Stack<int>();
            Assert.Throws<InvalidOperationException>(() => stack.Contains(1));
        }

        [Test]
        public void Contains_ValueInStack_ReturnsTrue()
        {
            var stack = new StructureData.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.That(stack.Contains(2), Is.True);
        }

        [Test]
        public void Contains_ValueNotInStack_ReturnsFalse()
        {
            var stack = new StructureData.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.That(stack.Contains(4), Is.False);
        }
    }
}