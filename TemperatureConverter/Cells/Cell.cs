using System;
using System.ComponentModel;

namespace Cells
{
    public class Cell<T> : INotifyPropertyChanged
    {
        private T contents;

        public event PropertyChangedEventHandler PropertyChanged;

        public Cell(T initialContents = default(T))
        {
            this.contents = initialContents;
        }

        public T Value
        {
            get
            {
                return contents;
            }
            set
            {
                this.contents = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
            }
        }

    }
}
