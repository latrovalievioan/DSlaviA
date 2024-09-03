namespace Intro;

public class DynamicList<T>
{
    private int _cap = 0;
    private int _size = 0;
    private T[] _items = new T[0];

    void PushBack(T toAdd)
    {
        if(_size == _cap) 
        {
            Upsize();
        }

        _items[_size] = toAdd;
        _size++;
    }

    T PopBack()
    {   
        throw new NotImplementedException();
    }

    private void Upsize()
    {
        var newCap = _cap == 0 ? 1 : _cap * 2;
        var newItems = new T[newCap];
        
        for(int i = 0; i < _cap; i++)
        {
            newItems[i] = _items[i];
        }

        _items = newItems;
        _cap = newCap;
    }

}
