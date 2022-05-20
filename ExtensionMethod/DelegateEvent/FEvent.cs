using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    public delegate void OnFiveHandler(object sender, EventArgs e);

    public class FEvent
    {
        public event OnFiveHandler FiveEvent;

        public void OnFiveEvent()
        {
            if (FiveEvent != null)
                FiveEvent(this, EventArgs.Empty);
        } 
    }
}
