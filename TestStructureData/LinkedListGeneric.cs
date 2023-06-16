using StructureData;

namespace TestStructureData;

[TestFixture]
public class LinkedListGenericTests
{
    [Test]
    public void Count_EmptyList_ReturnsZero()
    {
        // Arrange
        var list = new LinkedListGeneric<int>();

        // Act
        var count = list.Count();

        // Assert
        Assert.That(count, Is.EqualTo(0));
    }

    [Test]
    public void RemoveFirst_EmptyList_ThrowsInvalidOperationException()
    {
        // Arrange
        var list = new LinkedListGeneric<int>();

        // Assert
        Assert.Throws<InvalidOperationException>(() => list.RemoveFirst());
    }

    [Test]
    public void RemoveFirst_NonEmptyList_RemovesFirstElement()
    {
        // Arrange
        var list = new LinkedListGeneric<int>();
        list.AddLast(1);
        list.AddLast(2);

        // Act
        list.RemoveFirst();

        // Assert
        Assert.That(list.Count(), Is.EqualTo(1));
        Assert.That(list[0], Is.EqualTo(2));
    }

    [Test]
    public void RemoveLast_EmptyList_ThrowsInvalidOperationException()
    {
        // Arrange
        var list = new LinkedListGeneric<int>();

        // Assert
        Assert.Throws<InvalidOperationException>(() => list.RemoveLast());
    }

    [Test]
    public void RemoveLast_NonEmptyList_RemovesLastElement()
    {
        // Arrange
        var list = new LinkedListGeneric<int>();
        list.AddLast(1);
        list.AddLast(2);

        // Act
        list.RemoveLast();
        Assert.Multiple(() =>
        {

            // Assert
            Assert.That(list.Count(), Is.EqualTo(1));
            Assert.That(list[0], Is.EqualTo(1));
        });
    }

    [Test]
    public void RemoveFirst_WhenListIsEmpty_ShouldThrowException()
    {
        // Arrange
        var list = new LinkedListGeneric<int>();

        //Act
        //Assert
        Assert.Throws<InvalidOperationException>(() => list.RemoveFirst());
    }
    
    [Test]
        public void AddAfter_EmptyList_AddsValue()
    {
        var list = new LinkedListGeneric<int>();
            list.AddAfter(0, 1);
        Assert.Multiple(() =>
        {
            Assert.That(list.Count(), Is.EqualTo(1));
            Assert.That(list[0], Is.EqualTo(1));
        });
    }

    [Test]
        public void AddAfter_ValueFound_InsertsValueAfter()
    {
        var list = new LinkedListGeneric<int>();
            list.AddLast(1);
            list.AddLast(3);
            list.AddAfter(1, 2);
        Assert.Multiple(() =>
        {
            Assert.That(list.Count(), Is.EqualTo(3));
            Assert.That(list[0], Is.EqualTo(1));
            Assert.That(list[1], Is.EqualTo(2));
            Assert.That(list[2], Is.EqualTo(3));
        });
    }

    [Test]
        public void AddAfter_ValueNotFound_ThrowsInvalidOperationException()
        {
            var list = new LinkedListGeneric<int>();
            list.AddLast(1);
            list.AddLast(3);
            Assert.Throws<InvalidOperationException>(() => list.AddAfter(2, 4));
        }

        [Test]
        public void AddBefore_EmptyList_AddsValue()
    {
        var list = new LinkedListGeneric<int>();
            list.AddBefore(0, 1);
        Assert.Multiple(() =>
        {
            Assert.That(list.Count(), Is.EqualTo(1));
            Assert.That(list[0], Is.EqualTo(1));
        });
    }

    [Test]
        public void AddBefore_FirstValue_InsertsValueBefore()
    {
        var list = new LinkedListGeneric<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddBefore(2, 1);
        Assert.Multiple(() =>
        {
            Assert.That(list.Count(), Is.EqualTo(3));
            Assert.That(list[0], Is.EqualTo(1));
            Assert.That(list[1], Is.EqualTo(2));
            Assert.That(list[2], Is.EqualTo(3));
        });
    }

    [Test]
        public void AddBefore_ValueFound_InsertsValueBefore()
    {
        var list = new LinkedListGeneric<int>();
            list.AddLast(1);
            list.AddLast(3);
            list.AddBefore(3, 2);
        Assert.Multiple(() =>
        {
            Assert.That(list.Count(), Is.EqualTo(3));
            Assert.That(list[0], Is.EqualTo(1));
            Assert.That(list[1], Is.EqualTo(2));
            Assert.That(list[2], Is.EqualTo(3));
        });
    }

    [Test]
        public void AddBefore_ValueNotFound_ThrowsInvalidOperationException()
        {
            var list = new LinkedListGeneric<int>();
            list.AddLast(1);
            list.AddLast(3);
            Assert.Throws<InvalidOperationException>(() => list.AddBefore(2, 4));
        }

        [Test]
        public void AddFirst_EmptyList_AddsValue()
    {
        var list = new LinkedListGeneric<int>();
            list.AddFirst(1);
        Assert.Multiple(() =>
        {
            Assert.That(list.Count(), Is.EqualTo(1));
            Assert.That(list[0], Is.EqualTo(1));
        });
    }

    [Test]
        public void AddFirst_NonEmptyList_AddsValueAtFirstIndex()
    {
        var list = new LinkedListGeneric<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddFirst(1);
        Assert.Multiple(() =>
        {
            Assert.That(list.Count(), Is.EqualTo(3));
            Assert.That(list[0], Is.EqualTo(1));
            Assert.That(list[1], Is.EqualTo(2));
            Assert.That(list[2], Is.EqualTo(3));
        });
    }

    [Test]
        public void AddLast_EmptyList_AddsValue()
    {
        var list = new LinkedListGeneric<int>();
            list.AddLast(1);
        Assert.Multiple(() =>
        {
            Assert.That(list.Count(), Is.EqualTo(1));
            Assert.That(list[0], Is.EqualTo(1));
        });
    }

    [Test]
        public void AddLast_NonEmptyList_AddsValueAtLastIndex()
    {
        var list = new LinkedListGeneric<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
        Assert.Multiple(() =>
        {
            Assert.That(list.Count(), Is.EqualTo(3));
            Assert.That(list[0], Is.EqualTo(1));
            Assert.That(list[1], Is.EqualTo(2));
            Assert.That(list[2], Is.EqualTo(3));
        });
    }
}