

using System;

namespace ISP
{
    public interface IOpenable
    {
        void Open();
    }

    public interface IEditable
    {
        void Edit();
    }

    public interface ISaveable
    {
        void Save();
    }

    public class TextDocument : IOpenable, IEditable, ISaveable
    {
        public void Open()
        {
            Console.WriteLine("Opening text document...");
        }

        public void Edit()
        {
            Console.WriteLine("Editing text document...");
        }

        public void Save()
        {
            Console.WriteLine("Saving text document...");
        }
    }

    public class SpreadsheetDocument : IOpenable, IEditable, ISaveable
    {
        public void Open()
        {
            Console.WriteLine("Opening spreadsheet document...");
        }

        public void Edit()
        {
            Console.WriteLine("Editing spreadsheet document...");
        }

        public void Save()
        {
            Console.WriteLine("Saving spreadsheet document...");
        }
    }

    public class PresentationDocument : IOpenable, ISaveable
    {
        public void Open()
        {
            Console.WriteLine("Opening presentation document...");
        }

        public void Save()
        {
            Console.WriteLine("Saving presentation document...");
        }
    }
}
