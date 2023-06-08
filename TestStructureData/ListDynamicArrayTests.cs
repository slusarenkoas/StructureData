using StructureData;

namespace TestStructureData;

[TestFixture]
public class ListDynamicArrayTests
{
    [Test]
    public void Add_ShouldIncreaseCount()
    {
        // Arrange
        var list = new ListDynamicArray<int>();

        // Act
        list.Add(5);

        // Assert
        Assert.That(list.Count, Is.EqualTo(1));
    }

    [Test]
    public void Clear_ShouldResetCountToZero()
    {
        // Arrange
        var list = new ListDynamicArray<int>();
        list.Add(1);
        list.Add(2);

        // Act
        list.Clear();

        // Assert
        Assert.That(list.Count, Is.EqualTo(0));
    }

    [Test]
    public void IndexOf_ShouldReturnCorrectIndex()
    {
        // Arrange
        var list = new ListDynamicArray<string>();
        list.Add("apple");
        list.Add("banana");
        list.Add("orange");

        // Act
        var index = list.IndexOf("banana");

        // Assert
        Assert.That(index, Is.EqualTo(1));
    }

    [Test]
    public void Insert_ShouldInsertValueAtGivenIndex()
    {
        // Arrange
        var list = new ListDynamicArray<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);

        // Act
        list.Insert(1, 10);

        // Assert
        Assert.That(list.Count, Is.EqualTo(4));
        Assert.Multiple(() =>
        {
            Assert.That(list[0], Is.EqualTo(1));
            Assert.That(list[1], Is.EqualTo(10));
            Assert.That(list[2], Is.EqualTo(2));
            Assert.That(list[3], Is.EqualTo(3));
        });
    }

    [Test]
    public void Remove_ShouldRemoveFirstMatchingValue()
    {
        // Arrange
        var list = new ListDynamicArray<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(2);

        // Act
        list.Remove(2);

        // Assert
        Assert.That(list.Count, Is.EqualTo(3));
        Assert.Multiple(() =>
        {
            Assert.That(list[0], Is.EqualTo(1));
            Assert.That(list[1], Is.EqualTo(3));
            Assert.That(list[2], Is.EqualTo(2));
        });
    }

    [Test]
    public void RemoveAt_ShouldRemoveValueAtGivenIndex()
    {
        // Arrange
        var list = new ListDynamicArray<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);

        // Act
        list.RemoveAt(1);

        // Assert
        Assert.That(list.Count, Is.EqualTo(2));
        Assert.Multiple(() =>
        {
            Assert.That(list[0], Is.EqualTo(1));
            Assert.That(list[1], Is.EqualTo(3));
        });
    }

    [Test]
    public void Sort_ShouldSortTheList()
    {
        // Arrange
        var list = new ListDynamicArray<int>();
        list.Add(3);
        list.Add(1);
        list.Add(2);

        // Act
        list.Sort();

        // Assert
        Assert.That(list.Count, Is.EqualTo(3));
        Assert.Multiple(() =>
        {
            Assert.That(list[0], Is.EqualTo(1));
            Assert.That(list[1], Is.EqualTo(2));
            Assert.That(list[2], Is.EqualTo(3));
        });
    }

    [Test]
    public void Reverse_ShouldReverseTheList()
    {
        // Arrange
        var list = new ListDynamicArray<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);

        // Act
        list.Reverse();

        // Assert
        Assert.That(list.Count, Is.EqualTo(3));
        Assert.Multiple(() =>
        {
            Assert.That(list[0], Is.EqualTo(3));
            Assert.That(list[1], Is.EqualTo(2));
            Assert.That(list[2], Is.EqualTo(1));
        });
    }
}