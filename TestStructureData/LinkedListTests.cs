using StructureData;

namespace TestStructureData;

    [TestFixture]
    public class LinkedListTests
    {
        [Test]
        public void AddAfter_WhenNodeIsNull_ShouldThrowException()
        {
            // Arrange
            var list = new StructureData.LinkedList<string?>();

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => list.AddAfter(null, "test"));
        }

        [Test]
        public void AddAfter_WhenListIsEmpty_ShouldAddNodeAsFirst()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
        list.AddFirst(1);

        // Act
        list.AddAfter(1, 5);

        // Assert
        Assert.That(list.Count, Is.EqualTo(2));
        Assert.Multiple(() =>
        {
            if (list.First != null) Assert.That(list.First.Value, Is.EqualTo(1));
            if (list.Last != null) Assert.That(list.Last.Value, Is.EqualTo(5));
        });
    }

    [Test]
        public void AddAfter_WhenNodeIsLast_ShouldAddNodeAsLast()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
        list.AddFirst(1);

            // Act
            list.AddAfter(1, 2);

            // Assert
            Assert.That(list.Count, Is.EqualTo(2));
        Assert.Multiple(() =>
        {
            if (list.First != null) Assert.That(list.First.Value, Is.EqualTo(1));
            if (list.Last != null) Assert.That(list.Last.Value, Is.EqualTo(2));
        });
    }

    [Test]
        public void AddAfter_WhenNodeIsInMiddle_ShouldAddNodeAfterGivenNode()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
        list.AddFirst(1);
            list.AddLast(3);

            // Act
            list.AddAfter(1, 2);

            // Assert
            Assert.That(list.Count, Is.EqualTo(3));
        Assert.Multiple(() =>
        {
            if (list.First != null) Assert.That(list.First.Value, Is.EqualTo(1));
            if (list.Last != null) Assert.That(list.Last.Value, Is.EqualTo(3));
            if (list.First == null) return;
            if (list.First.Next != null)
                Assert.That(list.First.Next.Value, Is.EqualTo(2));
        });
    }

    [Test]
        public void AddBefore_WhenNodeIsNull_ShouldThrowException()
        {
            // Arrange
            var list = new StructureData.LinkedList<Node<int>?>();
            var newNode = new Node<int>(5);

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => list.AddBefore(null, newNode));
        }

        [Test]
        public void AddBefore_WhenListIsEmpty_ShouldAddNodeAsFirst()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
        list.AddFirst(1);

        // Act
        list.AddBefore(1, 5);

        // Assert
        Assert.That(list.Count, Is.EqualTo(2));
        Assert.Multiple(() =>
        {
            if (list.First != null) Assert.That(list.First.Value, Is.EqualTo(5));
            if (list.Last != null) Assert.That(list.Last.Value, Is.EqualTo(1));
        });
    }

    [Test]
        public void AddBefore_WhenNodeIsFirst_ShouldAddNodeAsFirst()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
        list.AddFirst(2);

            // Act
            list.AddBefore(2, 1);

            // Assert
            Assert.That(list.Count, Is.EqualTo(2));
        Assert.Multiple(() =>
        {
            if (list.First != null) Assert.That(list.First.Value, Is.EqualTo(1));
            if (list.Last != null) Assert.That(list.Last.Value, Is.EqualTo(2));
        });
    }

    [Test]
        public void AddBefore_WhenNodeIsInMiddle_ShouldAddNodeBeforeGivenNode()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
            var firstNode = new Node<int>(1);
            var middleNode = new Node<int>(2);
            list.AddFirst(1);
            list.AddLast(3);

            // Act
            list.AddBefore(3, 2);

            // Assert
            Assert.That(list.Count, Is.EqualTo(3));
        Assert.Multiple(() =>
        {
            if (list.First != null) Assert.That(list.First.Value, Is.EqualTo(1));
            if (list.Last != null) Assert.That(list.Last.Value, Is.EqualTo(3));
            if (firstNode.Next == null) return;
            Assert.That(firstNode.Next.Value, Is.EqualTo(2));
            if (middleNode.Next != null) Assert.That(middleNode.Next.Value, Is.EqualTo(3));
        });
    }

    [Test]
        public void RemoveFirst_WhenListIsEmpty_ShouldThrowException()
        {
            // Arrange
            var list = new StructureData.LinkedList<int>();

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => list.RemoveFirst());
        }

        [Test]
        public void RemoveFirst_WhenListHasSingleElement_ShouldRemoveElementAndMakeListEmpty()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
            list.AddFirst(5);

            // Act
            list.RemoveFirst();

            // Assert
            Assert.That(list.Count, Is.EqualTo(0));
        Assert.Multiple(() =>
        {
            Assert.That(list.First, Is.Null);
            Assert.That(list.Last, Is.Null);
        });
    }

    [Test]
        public void RemoveFirst_WhenListHasMultipleElements_ShouldRemoveFirstElement()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
        list.AddFirst(1);
            list.AddLast(2);
            list.AddLast(3);

            // Act
            list.RemoveFirst();

            // Assert
            Assert.That(list.Count, Is.EqualTo(2));
        Assert.Multiple(() =>
        {
            if (list.First != null) Assert.That(list.First.Value, Is.EqualTo(2));
            if (list.Last != null) Assert.That(list.Last.Value, Is.EqualTo(3));
        });
    }
        
        [Test]
        public void RemoveLast_WhenListIsEmpty_ShouldThrowException()
        {
            // Arrange
            var list = new StructureData.LinkedList<int>();

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => list.RemoveLast());
        }

        [Test]
        public void RemoveLast_WhenListHasSingleElement_ShouldRemoveElementAndMakeListEmpty()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
        list.AddFirst(1);

            // Act
            list.RemoveLast();

            // Assert
            Assert.That(list.Count, Is.EqualTo(0));
        Assert.Multiple(() =>
        {
            Assert.That(list.First, Is.Null);
            Assert.That(list.Last, Is.Null);
        });
    }

    [Test]
        public void RemoveLast_WhenListHasMultipleElements_ShouldRemoveLastElement()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
        list.AddFirst(1);
            list.AddLast(2);
            list.AddLast(3);

            // Act
            list.RemoveLast();

            // Assert
            Assert.That(list.Count, Is.EqualTo(2));
        Assert.Multiple(() =>
        {
            if (list.First != null) Assert.That(list.First.Value, Is.EqualTo(1));
            if (list.Last != null) Assert.That(list.Last.Value, Is.EqualTo(2));
        });
    }

    [Test]
        public void AddFirst_WhenListIsEmpty_ShouldAddNodeAsFirst()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();

        // Act
            list.AddFirst(5);

            // Assert
            Assert.That(list.Count, Is.EqualTo(1));
        Assert.Multiple(() =>
        {
            if (list.First != null) Assert.That(list.First.Value, Is.EqualTo(5));
            if (list.Last != null) Assert.That(list.Last.Value, Is.EqualTo(5));
        });
    }

    [Test]
        public void AddFirst_WhenListIsNotEmpty_ShouldAddNodeAsFirst()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
        list.AddFirst(1);

            // Act
            list.AddFirst(2);

            // Assert
            Assert.That(list.Count, Is.EqualTo(2));
        Assert.Multiple(() =>
        {
            if (list.First != null) Assert.That(list.First.Value, Is.EqualTo(2));
            if (list.Last != null) Assert.That(list.Last.Value, Is.EqualTo(1));
        });
    }

    [Test]
        public void AddLast_WhenListIsEmpty_ShouldAddNodeAsLast()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
        // Act
            list.AddLast(5);

            // Assert
            Assert.That(list.Count, Is.EqualTo(1));
        Assert.Multiple(() =>
        {
            if (list.First != null) Assert.That(list.First.Value, Is.EqualTo(5));
            if (list.Last != null) Assert.That(list.Last.Value, Is.EqualTo(5));
        });
    }

    [Test]
        public void AddLast_WhenListIsNotEmpty_ShouldAddNodeAsLast()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
        list.AddFirst(1);

            // Act
            list.AddLast(2);

            // Assert
            Assert.That(list.Count, Is.EqualTo(2));
        Assert.Multiple(() =>
        {
            if (list.First != null) Assert.That(list.First.Value, Is.EqualTo(1));
            if (list.Last != null) Assert.That(list.Last.Value, Is.EqualTo(2));
        });
    }
}
