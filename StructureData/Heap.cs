namespace StructureData;

public class Heap <T> where T: IComparable
{
    private readonly List<T> _heapData = new();
    
    public int Count => _heapData.Count;

    public void Add(T value)
    {
        _heapData.Add(value);
        ShiftUp(_heapData.Count - 1);
    }

    private void ShiftUp(int index)
    {
        var parentIndex = (index - 1) / 2;

        var currentElement = _heapData[index];
        var parentElement = _heapData[parentIndex];

        if (currentElement.CompareTo(parentElement) > 0)
        {
            Swap(_heapData, index, parentIndex);
            ShiftUp(parentIndex);
        }
    }

    private void Swap(List<T> array, int leftIndex, int rightIndex)
    {
        (array[leftIndex], _heapData[rightIndex]) = (_heapData[rightIndex], _heapData[leftIndex]);
    }

    public T ExtractMaximum()
    {
        var result = _heapData[0];
        _heapData[0] = _heapData[^1];
        
        ShiftDown(0);

        return result;
    }

    private void ShiftDown(int index)
    {
        var leftChildIndex = index * 2 + 1;
        var rightChildIndex = index * 2 + 2;

        if (leftChildIndex >= _heapData.Count)
        {
            return;
        }

        var maxChildIndex = leftChildIndex;
        
        if (rightChildIndex < _heapData.Count &&
            _heapData[leftChildIndex].CompareTo(_heapData[rightChildIndex]) < 0)
        {

                maxChildIndex = rightChildIndex;
        }

        if (_heapData[index].CompareTo(_heapData[maxChildIndex]) > 0)
        {
            return;
        }
        
        Swap(_heapData,index,maxChildIndex);
        ShiftDown(maxChildIndex);
    }
}