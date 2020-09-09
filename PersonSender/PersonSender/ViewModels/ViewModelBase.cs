using PersonSender.Models;
using PersonSender.ViewModels.Commands;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSender.ViewModels
{
    public class ViewModelBase
    {
      
        public ParameterCommand ParameterCommand { get; set; }
        public ViewModelBase()
        {
            this.ParameterCommand = new ParameterCommand(this);
        }

      
        public void ParameterMethod(Person person)
        {

            Controller.Controller.Instance.SendPerson(person);
            Debug.WriteLine(person);
        }
    }
}
