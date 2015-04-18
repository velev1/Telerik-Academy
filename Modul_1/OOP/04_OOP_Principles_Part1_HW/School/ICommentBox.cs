namespace School
{
    using System.Collections.Generic;

    public interface ICommentBox
    {
        // properties
        List<string> FreeTextBox { get; }

        // metohods
        void AddFreeTextMessage(string text);
    }
}
