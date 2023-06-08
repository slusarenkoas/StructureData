using StructureData;

namespace TestStructureData;

    [TestFixture]
    public class LinkedListTests
    {
        [Test]
        public void AddAfter_WhenNodeIsNull_ShouldThrowException()
        {
            // Arrange
            var list = new StructureData.LinkedList<int>();
            var newNode = new Node<int>(5);

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => list.AddAfter(null, newNode));
        }

        [Test]
        public void AddAfter_WhenListIsEmpty_ShouldAddNodeAsFirst()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
        var existingNode = new Node<int>(1);
        var newNode = new Node<int>(5);
        list.AddFirst(existingNode);

        // Act
        list.AddAfter(existingNode, newNode);

        // Assert
        Assert.That(list.Count, Is.EqualTo(2));
        Assert.Multiple(() =>
        {
            Assert.That(list.First, Is.EqualTo(existingNode));
            Assert.That(list.Last, Is.EqualTo(newNode));
        });
    }

    [Test]
        public void AddAfter_WhenNodeIsLast_ShouldAddNodeAsLast()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
            var firstNode = new Node<int>(1);
            var lastNode = new Node<int>(2);
            list.AddFirst(firstNode);

            // Act
            list.AddAfter(firstNode, lastNode);

            // Assert
            Assert.That(list.Count, Is.EqualTo(2));
        Assert.Multiple(() =>
        {
            Assert.That(list.First, Is.EqualTo(firstNode));
            Assert.That(list.Last, Is.EqualTo(lastNode));
        });
    }

    [Test]
        public void AddAfter_WhenNodeIsInMiddle_ShouldAddNodeAfterGivenNode()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
            var firstNode = new Node<int>(1);
            var middleNode = new Node<int>(2);
            var lastNode = new Node<int>(3);
            list.AddFirst(firstNode);
            list.AddLast(lastNode);

            // Act
            list.AddAfter(firstNode, middleNode);

            // Assert
            Assert.That(list.Count, Is.EqualTo(3));
        Assert.Multiple(() =>
        {
            Assert.That(list.First, Is.EqualTo(firstNode));
            Assert.That(list.Last, Is.EqualTo(lastNode));
            Assert.That(firstNode.Next, Is.EqualTo(middleNode));
            Assert.That(middleNode.Next, Is.EqualTo(lastNode));
        });
    }

    [Test]
        public void AddBefore_WhenNodeIsNull_ShouldThrowException()
        {
            // Arrange
            var list = new StructureData.LinkedList<int>();
            var newNode = new Node<int>(5);

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => list.AddBefore(null, newNode));
        }

        [Test]
        public void AddBefore_WhenListIsEmpty_ShouldAddNodeAsFirst()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
        var existingNode = new Node<int>(1);
        var newNode = new Node<int>(5);
        list.AddFirst(existingNode);

        // Act
        list.AddBefore(existingNode, newNode);

        // Assert
        Assert.That(list.Count, Is.EqualTo(2));
        Assert.Multiple(() =>
        {
            Assert.That(list.First, Is.EqualTo(newNode));
            Assert.That(list.Last, Is.EqualTo(existingNode));
        });
    }

    [Test]
        public void AddBefore_WhenNodeIsFirst_ShouldAddNodeAsFirst()
        {
            // Arrange
            var list = new StructureData.LinkedList<int>();
            var firstNode = new Node<int>(1);
            var secondNode = new Node<int>(2);
            list.AddFirst(secondNode);

            // Act
            list.AddBefore(secondNode, firstNode);

            // Assert
            Assert.That(list.Count, Is.EqualTo(2));
            Assert.That(list.First, Is.EqualTo(firstNode));
            Assert.That(list.Last, Is.EqualTo(secondNode));
        }

        [Test]
        public void AddBefore_WhenNodeIsInMiddle_ShouldAddNodeBeforeGivenNode()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
            var firstNode = new Node<int>(1);
            var middleNode = new Node<int>(2);
            var lastNode = new Node<int>(3);
            list.AddFirst(firstNode);
            list.AddLast(lastNode);

            // Act
            list.AddBefore(lastNode, middleNode);

            // Assert
            Assert.That(list.Count, Is.EqualTo(3));
        Assert.Multiple(() =>
        {
            Assert.That(list.First, Is.EqualTo(firstNode));
            Assert.That(list.Last, Is.EqualTo(lastNode));
            Assert.That(firstNode.Next, Is.EqualTo(middleNode));
            Assert.That(middleNode.Next, Is.EqualTo(lastNode));
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
            var node = new Node<int>(5);
            list.AddFirst(node);

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
            var firstNode = new Node<int>(1);
            var secondNode = new Node<int>(2);
            var thirdNode = new Node<int>(3);
            list.AddFirst(firstNode);
            list.AddLast(secondNode);
            list.AddLast(thirdNode);

            // Act
            list.RemoveFirst();

            // Assert
            Assert.That(list.Count, Is.EqualTo(2));
        Assert.Multiple(() =>
        {
            if (list.First != null) Assert.That(list.First.Value, Is.EqualTo(secondNode.Value));
            if (list.Last != null) Assert.That(list.Last.Value, Is.EqualTo(thirdNode.Value));
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
            var node = new Node<int>(5);
            list.AddFirst(node);

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
            var firstNode = new Node<int>(1);
            var secondNode = new Node<int>(2);
            var thirdNode = new Node<int>(3);
            list.AddFirst(firstNode);
            list.AddLast(secondNode);
            list.AddLast(thirdNode);

            // Act
            list.RemoveLast();

            // Assert
            Assert.That(list.Count, Is.EqualTo(2));
        Assert.Multiple(() =>
        {
            Assert.That(list.First, Is.EqualTo(firstNode));
            Assert.That(list.Last, Is.EqualTo(secondNode));
        });
    }

    [Test]
        public void AddFirst_WhenListIsEmpty_ShouldAddNodeAsFirst()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
            var newNode = new Node<int>(5);

            // Act
            list.AddFirst(newNode);

            // Assert
            Assert.That(list.Count, Is.EqualTo(1));
        Assert.Multiple(() =>
        {
            Assert.That(list.First, Is.EqualTo(newNode));
            Assert.That(list.Last, Is.EqualTo(newNode));
        });
    }

    [Test]
        public void AddFirst_WhenListIsNotEmpty_ShouldAddNodeAsFirst()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
            var firstNode = new Node<int>(1);
            var newNode = new Node<int>(2);
            list.AddFirst(firstNode);

            // Act
            list.AddFirst(newNode);

            // Assert
            Assert.That(list.Count, Is.EqualTo(2));
        Assert.Multiple(() =>
        {
            Assert.That(list.First, Is.EqualTo(newNode));
            Assert.That(list.Last, Is.EqualTo(firstNode));
        });
    }

    [Test]
        public void AddLast_WhenListIsEmpty_ShouldAddNodeAsLast()
        {
            // Arrange
            var list = new StructureData.LinkedList<int>();
            var newNode = new Node<int>(5);

            // Act
            list.AddLast(newNode);

            // Assert
            Assert.That(list.Count, Is.EqualTo(1));
            Assert.That(list.First, Is.EqualTo(newNode));
            Assert.That(list.Last, Is.EqualTo(newNode));
        }

        [Test]
        public void AddLast_WhenListIsNotEmpty_ShouldAddNodeAsLast()
    {
        // Arrange
        var list = new StructureData.LinkedList<int>();
            var lastNode = new Node<int>(1);
            var newNode = new Node<int>(2);
            list.AddFirst(lastNode);

            // Act
            list.AddLast(newNode);

            // Assert
            Assert.That(list.Count, Is.EqualTo(2));
        Assert.Multiple(() =>
        {
            Assert.That(list.First, Is.EqualTo(lastNode));
            Assert.That(list.Last, Is.EqualTo(newNode));
        });
    }
}
