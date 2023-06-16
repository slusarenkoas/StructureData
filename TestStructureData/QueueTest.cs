namespace TestStructureData;

[TestFixture]
public class QueueTest
{
    [Test]
        public void Clear_EmptyQueue_ClearsQueue()
    {
        var queue = new StructureData.Queue<int>();
            queue.Clear();
            Assert.That(queue.Count, Is.EqualTo(0));
        Assert.Multiple(() =>
        {
            Assert.That(queue.First, Is.Null);
            Assert.That(queue.Last, Is.Null);
        });
    }

    [Test]
        public void Contains_EmptyQueue_ThrowsInvalidOperationException()
        {
            var queue = new StructureData.Queue<int>();
            Assert.Throws<InvalidOperationException>(() => queue.Contains(1));
        }

        [Test]
        public void Contains_ValueInQueue_ReturnsTrue()
        {
            var queue = new StructureData.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.IsTrue(queue.Contains(2));
        }

        [Test]
        public void Contains_ValueNotInQueue_ReturnsFalse()
        {
            var queue = new StructureData.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.IsFalse(queue.Contains(4));
        }

        [Test]
        public void Enqueue_EmptyQueue_AddsValue()
    {
        var queue = new StructureData.Queue<int>();
            queue.Enqueue(1);
            Assert.That(queue.Count, Is.EqualTo(1));
        Assert.Multiple(() =>
        {
            if (queue.First != null) Assert.That(queue.First.Value, Is.EqualTo(1));
            if (queue.Last != null) Assert.That(queue.Last.Value, Is.EqualTo(1));
        });
    }

    [Test]
        public void Enqueue_NonEmptyQueue_AddsValueAtEnd()
    {
        var queue = new StructureData.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.That(queue.Count, Is.EqualTo(3));
        Assert.Multiple(() =>
        {
            if (queue.First != null) Assert.That(queue.First.Value, Is.EqualTo(1));
            if (queue.Last != null) Assert.That(queue.Last.Value, Is.EqualTo(3));
        });
    }

    [Test]
        public void Dequeue_EmptyQueue_ThrowsInvalidOperationException()
        {
            var queue = new StructureData.Queue<int>();
            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        }

        [Test]
        public void Dequeue_NonEmptyQueue_RemovesAndReturnsFirstValue()
    {
        var queue = new StructureData.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            var value = queue.Dequeue();
        Assert.Multiple(() =>
        {
            Assert.That(value, Is.EqualTo(1));
            Assert.That(queue.Count, Is.EqualTo(2));
        });
        Assert.Multiple(() =>
        {
            if (queue.First != null) Assert.That(queue.First.Value, Is.EqualTo(2));
            if (queue.Last != null) Assert.That(queue.Last.Value, Is.EqualTo(3));
        });
    }

    [Test]
        public void Peek_EmptyQueue_ThrowsInvalidOperationException()
        {
            var queue = new StructureData.Queue<int>();
            Assert.Throws<InvalidOperationException>(() => queue.Peek());
        }

        [Test]
        public void Peek_NonEmptyQueue_ReturnsFirstValue()
    {
        var queue = new StructureData.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            var value = queue.Peek();
        Assert.Multiple(() =>
        {
            Assert.That(value, Is.EqualTo(1));
            Assert.That(queue.Count, Is.EqualTo(3));
        });
        Assert.Multiple(() =>
        {
            if (queue.First != null) Assert.That(queue.First.Value, Is.EqualTo(1));
            if (queue.Last != null) Assert.That(queue.Last.Value, Is.EqualTo(3));
        });
    }
}