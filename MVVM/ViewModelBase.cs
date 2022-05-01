using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM
{
    public class ViewModelBase
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}