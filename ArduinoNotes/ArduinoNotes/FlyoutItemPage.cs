using System;
using System.Collections.Generic;
using System.Text;

namespace ArduinoNotes
{
    class FlyoutItemPage
    {
        public string Title { get; set; } = "ArduinoNotes";
        public string IconSource { get; set; }
        public Type TargetPage { get; set; }
    }
}
