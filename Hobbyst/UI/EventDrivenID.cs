using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobbyst.UI
{
    public class EventDrivenID
    {
        public delegate void NotifyIDUpdatedHandler();
        public event NotifyIDUpdatedHandler UpdateIDEvent;
        
        private int id;

        public int ID
        {
            get { return id; }
            set
            {
                this.id = value; 
                if (UpdateIDEvent != null) 
                    UpdateIDEvent.Invoke();
            }
        }

        //private EventDrivenID eventdrivenid;
        //public AddableForm(EventDrivenID eventdrivenid)
        //{
        //    InitializeComponent();
        //    this.eventdrivenid = eventdrivenid;
        //    eventdrivenid.UpdateIDEvent += this.UpdateLabel; //whatever method you want to fire upon invocation of the event
        //}
    }
}
