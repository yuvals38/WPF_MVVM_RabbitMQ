using PersonSender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PersonSender.ViewModels.Commands
{
    public class ParameterCommand : ICommand
    {
        public ViewModelBase ViewModel { get; set; }

        public ParameterCommand(ViewModelBase viewModel)
        {
            this.ViewModel = viewModel;
        }
        public event EventHandler CanExecuteChanged
        {
            add
            {

                CommandManager.RequerySuggested += value;
            }
            remove
            {

                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            if(parameter != null)
                 return true;
            
           return false;
        }

        public void Execute(object parameter)
        {
            this.ViewModel.ParameterMethod(parameter as Person);
        }
    }
}
