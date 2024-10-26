namespace DZ_Lesson_11_Classes_Dop3
{
    public class Stack
    {
        private StackItem _stackItem = null;

        private int _size;
        public int Size => _size;

        private string? _top;
        public string? Top
        {
            get
            {
                if (_size == 0)
                    return null;
                return _top;
            }
        }

        public Stack(params string[] elements)
        {
            elements.ToList().ForEach(x => Add(x));
        }

        public void Add(string element)
        {
            _top = element;
            _size++;
            _stackItem = new StackItem(_stackItem, element);            
        }

        public string Pop()
        {
            if (_size == 0)
                throw new EmptyStackException();

            string currentValue = _stackItem.Value;

            _stackItem = _stackItem.Item;
            _size--;
            _top = _stackItem == null ? null : _stackItem.Value;

            return currentValue;
        }
    }
}
