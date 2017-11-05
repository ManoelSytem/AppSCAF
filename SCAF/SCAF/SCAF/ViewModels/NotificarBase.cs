
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace SCAF.ViewModels
{
    public class NotificarBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void Notificar([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
