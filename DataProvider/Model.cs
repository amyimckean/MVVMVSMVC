using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    public class Model
    {
        private string _lastName = DataProvider.LastName;
        private string _firstName = DataProvider.FirstName;
        private DateTime _birthDate = DataProvider.BirthDate;
        private bool _batsLeft = DataProvider.Hit_Left;
        private bool _throwsLeft = DataProvider.Throw_Left;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; OnPropertyChanged("LastName"); }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; OnPropertyChanged("FirstName"); }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; OnPropertyChanged("BirthDate"); }
        }

        public bool BatsLeft
        {
            get { return _batsLeft; }
            set { _batsLeft = value; OnPropertyChanged("BatsLeft"); }
        }
        public bool ThrowsLeft
        {
            get { return _throwsLeft; }
            set { _throwsLeft = value; OnPropertyChanged("ThrowsLeft"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
