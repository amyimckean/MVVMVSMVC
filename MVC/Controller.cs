using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public class Controller
    {
        private Model _model;
        private View? _view;

        public Controller(View? view, Model model)
        {
            _model = model;
            _view = view;
            if (_view != null)
            {
                _view.FirstName.Text = _model.FirstName;
                _view.LastName.Text = _model.LastName;
                _view.BirthDatePicker.Text = _model.BirthDate.ToString();
                _view.BatsLeft.IsChecked = _model.BatsLeft;
                _view.BatsRight.IsChecked = !_model.BatsLeft;
                _view.ThrowsLeft.IsChecked = _model.ThrowsLeft;
                _view.ThrowsRight.IsChecked = !_model.ThrowsLeft;

                _view.SaveButton.Click += SaveButton_Click;
                _view.BatsLeft.Click += BatsLeft_Click;
                _view.BatsRight.Click += BatsRight_Click;
                _view.ThrowsLeft.Click += ThrowsLeft_Click;
                _view.ThrowsRight.Click += ThrowsRight_Click;
            }
        }

        public void ShowView()
        {
            _view?.Show();
        }

        private void ThrowsRight_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SetThrows(false, true);
        }

        private void ThrowsLeft_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SetThrows(true, false);
        }

        public void SetThrows(bool left, bool right)
        {
            if (_view != null)
            {
                _view.ThrowsLeft.IsChecked = left;
                _view.ThrowsRight.IsChecked = right;
            }
            _model.ThrowsLeft = left;
        }

        private void BatsRight_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SetBats(false, true);
        }

        private void BatsLeft_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SetBats(true, false);
        }

        public void SetBats(bool left, bool right)
        {
            if (_view != null)
            {
                _view.BatsLeft.IsChecked = left;
                _view.BatsRight.IsChecked = right;
            }
            _model.BatsLeft = left;
        }

        public void SaveButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (_view != null)
            {
                _model.FirstName = _view.FirstName.Text;
                _model.LastName = _view.LastName.Text;
                _model.BirthDate = Convert.ToDateTime(_view.BirthDatePicker.Text);
                _model.BatsLeft = (bool)_view.BatsLeft.IsChecked;
                _model.ThrowsLeft = (bool)_view.ThrowsLeft.IsChecked;
            }
        }
    }
}
