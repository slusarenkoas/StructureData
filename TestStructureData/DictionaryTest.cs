namespace TestStructureData;

public class DictionaryTest
{
    [TestFixture]
    public class DictionaryTests
    {
        [Test]
        public void Add_WhenKeyDoesNotExist_ShouldAddKeyValuePair()
        {
            // Arrange
            var dictionary = new StructureData.Dictionary<string, int>();

            // Act
            dictionary.Add("Key1", 1);
            dictionary.Add("Key2", 2);

            // Assert
            Assert.That(dictionary, Has.Count.EqualTo(2));
            Assert.Multiple(() =>
            {
                Assert.That(dictionary["Key1"], Is.EqualTo(1));
                Assert.That(dictionary["Key2"], Is.EqualTo(2));
            });
        }

        [Test]
        public void Add_WhenKeyExists_ShouldThrowArgumentException()
        {
            // Arrange
            // Arrange
            var dictionary = new StructureData.Dictionary<string, int>();
            dictionary.Add("Key1", 1);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => dictionary.Add("Key1", 2));
        }

        [Test]
        public void Remove_WhenKeyExists_ShouldRemoveKeyValuePairAndReturnTrue()
        {
            // Arrange
            var dictionary = new StructureData.Dictionary<string, int>();
            dictionary.Add("Key1", 1);

            // Act
            var result = dictionary.Remove("Key1");
            Assert.Multiple(() =>
            {

                // Assert
                Assert.That(result, Is.True);
                Assert.That(dictionary, Is.Empty);
            });
            Assert.Throws<KeyNotFoundException>(() => { var unused = dictionary["Key1"]; });
        }

        [Test]
        public void Remove_WhenKeyDoesNotExist_ShouldReturnFalse()
        {
            // Arrange
            var dictionary = new StructureData.Dictionary<string, int>();
            dictionary.Add("Key1", 1);

            // Act
            var result = dictionary.Remove("Key2");

            // Assert
            Assert.That(result, Is.False);
            Assert.That(dictionary, Has.Count.EqualTo(1));
        }

        [Test]
        public void TryGetValue_WhenKeyExists_ShouldReturnTrueAndAssignValue()
        {
            // Arrange
            var dictionary = new StructureData.Dictionary<string, int>();
            dictionary.Add("Key1", 1);

            // Act
            var result = dictionary.TryGetValue("Key1", out var value);
            Assert.Multiple(() =>
            {

                // Assert
                Assert.That(result, Is.True);
                Assert.That(value, Is.EqualTo(1));
            });
        }

        [Test]
        public void TryGetValue_WhenKeyDoesNotExist_ShouldReturnFalseAndAssignDefaultValue()
        {
            // Arrange
            var dictionary = new StructureData.Dictionary<string, int>();
            dictionary.Add("Key1", 1);

            // Act
            var result = dictionary.TryGetValue("Key2", out var value);
            Assert.Multiple(() =>
            {

                // Assert
                Assert.That(result, Is.False);
                Assert.That(value, Is.EqualTo(default(int)));
            });
        }

        [Test]
        public void Indexer_Get_WhenKeyExists_ShouldReturnValue()
        {
            // Arrange
            var dictionary = new StructureData.Dictionary<string, int>();
            dictionary.Add("Key1", 1);

            // Act
            var value = dictionary["Key1"];

            // Assert
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Indexer_Get_WhenKeyDoesNotExist_ShouldThrowKeyNotFoundException()
        {
            // Arrange
            var dictionary = new StructureData.Dictionary<string, int>();

            // Act & Assert
            Assert.Throws<KeyNotFoundException>(() => { var unused = dictionary["Key1"]; });
        }

        [Test]
        public void Indexer_Set_WhenKeyExists_ShouldUpdateValue()
        {
            // Arrange
            var dictionary = new StructureData.Dictionary<string, int>();
            dictionary.Add("Key1", 1);

            // Act
            dictionary["Key1"] = 2;

            // Assert
            Assert.That(dictionary["Key1"], Is.EqualTo(2));
        }

        [Test]
        public void Indexer_Set_WhenKeyDoesNotExist_ShouldAddKeyValuePair()
        {
            // Arrange
            var dictionary = new StructureData.Dictionary<string, int>();

            // Act
            dictionary["Key1"] = 1;
            Assert.Multiple(() =>
            {

                // Assert
                Assert.That(dictionary["Key1"], Is.EqualTo(1));
                Assert.That(dictionary.Count, Is.EqualTo(1));
            });
        }

        [Test]
        public void ContainsKey_ExistingKey_ReturnsTrue()
        {
            // Arrange
            var dictionary = new StructureData.Dictionary<string, int>();
            dictionary.Add("Key1", 1);
            dictionary.Add("Key2", 2);
            dictionary.Add("Key3", 3);

            // Act
            bool containsKey = dictionary.ContainsKey("Key2");

            // Assert
            Assert.True(containsKey);
        }

        [Test]
        public void ContainsKey_NonExistingKey_ReturnsFalse()
        {
            // Arrange
            var dictionary = new StructureData.Dictionary<string, int>();
            dictionary.Add("Key1", 1);
            dictionary.Add("Key2", 2);
            dictionary.Add("Key3", 3);

            // Act
            bool containsKey = dictionary.ContainsKey("Key4");

            // Assert
            Assert.False(containsKey);
        }

        [Test]
        public void Count_EmptyDictionary_ReturnsZero()
        {
            // Arrange
            var dictionary = new StructureData.Dictionary<string, int>();

            // Act
            int count = dictionary.Count;

            // Assert
            Assert.That(count, Is.EqualTo(0));
        }

        [Test]
        public void Count_NonEmptyDictionary_ReturnsNumberOfItems()
        {
            // Arrange
            var dictionary = new StructureData.Dictionary<string, int>();
            dictionary.Add("Key1", 1);
            dictionary.Add("Key2", 2);
            dictionary.Add("Key3", 3);

            // Act
            int count = dictionary.Count;

            // Assert
            Assert.That(count, Is.EqualTo(3));
        }
    }
}