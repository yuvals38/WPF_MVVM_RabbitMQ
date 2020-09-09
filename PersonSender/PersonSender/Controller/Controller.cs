using PersonSender.Controller.Services;
using PersonSender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSender.Controller
{

    public class Controller
    {
        static Controller instance = null;
        static readonly object padlock = new object();
        MsgService msgService;
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Controller();
                        }
                    }
                }
                return instance;
            }
        }

        public Controller()
        {
            //start service
            msgService = new MsgService();
          
        }

        public void SendPerson(Person person)
        {
            msgService.SendMsg(person);
        }


    }
}
