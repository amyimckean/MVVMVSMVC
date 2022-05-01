using DataProvider;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MVVM
{
    public class ViewModel : ViewModelBase
    {
        private Model _model;
        private bool _isHitRight;
        private bool _isThrowRight;

        public ViewModel(){
            setVariables(new Model());
        }
        public ViewModel(Model model)
        {
            setVariables(model);
        }

        private void setVariables(Model model)
        {
            Model = model;
            _isHitRight = !_model.BatsLeft;
            _isThrowRight = !_model.ThrowsLeft;
        }

        public Model Model
        {
            get => _model;
            set
            {
                _model = value;
                OnPropertyChanged("Model");
            }
        }

        public bool IsHitRight
        {
            get => _isHitRight;
            set
            {
                _isHitRight = value;
                OnPropertyChanged("IsHitRight");
            }
        }
        public bool IsThrowRight
        {
            get => _isThrowRight;
            set
            {
                _isThrowRight = value;
                OnPropertyChanged("IsThrowRight");
            }
        }


        public ICommand OnBatsClick => new RelayCommand(OnBatsChange);
        public ICommand OnThrowsClick => new RelayCommand(OnThrowsChange);


        public void OnBatsChange(object Control)
        {
            IsHitRight = !IsHitRight;
            Model.BatsLeft = !Model.BatsLeft;
        }

        public void OnThrowsChange(object Control)
        {
            IsThrowRight = !IsThrowRight;
            Model.ThrowsLeft = !Model.ThrowsLeft;
        }
    }
}
