using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="execute"></param>
        public RelayCommand(Action<object> execute) : this(execute, null) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="canExecute"></param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException(nameof(execute));
            _execute = execute;
            _canExecute = canExecute;
        }

        #region ICommand Members 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }
        #endregion // ICommand Members 
    }
}
