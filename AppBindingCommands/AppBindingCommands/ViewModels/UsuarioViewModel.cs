using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppBindingCommands.ViewModel
{
    public class UsuarioViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string name = string.Empty;

        public string DisplayName => $"Nome Digitado {Name}:";

        public string Name
        {
            get => name;
            set
            {
                if (name == null) return;

                name = value;
                OnPropertyChanged(nameof(name));
                OnPropertyChanged(nameof(DisplayName));
            }
        }

        public string DisplayMassage
        {
            get => DisplayMassage;
            set
            {
                if (DisplayMassage == null) return;

                DisplayMassage = value;
                OnPropertyChanged(nameof(DisplayMassage));
            }
        }
        
        public ICommand ShowMassageCommand { get; }
        public void ShowMassage()
        {
            DateTime data = Preferences.Get("dtAtual", DateTime.MinValue);
            DisplayMassage = $"Boa noite {Name}, Hoje é {data}";
        }
        public UsuarioViewModel()
        {
            ShowMassageCommand = new Command(ShowMassage);
        }
    }
}


