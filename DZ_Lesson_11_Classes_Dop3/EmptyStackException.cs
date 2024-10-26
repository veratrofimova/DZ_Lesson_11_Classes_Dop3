namespace DZ_Lesson_11_Classes_Dop3
{
    public class EmptyStackException : Exception
    {
        public EmptyStackException() : base("\r\nСтек пустой") { }
    }
}
