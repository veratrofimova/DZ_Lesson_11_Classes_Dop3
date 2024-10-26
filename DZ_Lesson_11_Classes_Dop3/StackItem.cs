namespace DZ_Lesson_11_Classes_Dop3
{
    internal class StackItem
    {   
        public StackItem Item { get; set; }
        public string Value { get; set; }

        static string? _previousElement;
        static string? _top;

        public StackItem(StackItem stackItem, string element)
        {
            _previousElement = _top;
            _top = element;
            Item = stackItem;
            Value = element;
        }
    }
}