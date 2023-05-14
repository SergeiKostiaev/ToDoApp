using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    internal class TodoModel : INotifyPropertyChanged
    {
		private bool _isDone;
        private string _text;

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public bool isDone
        {
			get { return _isDone; }
			set {
                if (_isDone == value)
                    return;
                _isDone = value;
                OnPropertyChange(nameof(isDone));
            }
		}

        public string Text  
        {
            get { return _text; }
            set { 
                if(_text == value)
                    return;
                _text = value;
                OnPropertyChange(nameof(Text));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    
        protected virtual void OnPropertyChange(string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
