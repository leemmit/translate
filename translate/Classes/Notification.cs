using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using translate;

namespace translate.Classes
{
    class Notification
    {
        public static void notify(string title = "Уведомление", string text = "Это ваше уведомление!")
        {
            Form1.NotifyIcon.BalloonTipTitle = title;
            Form1.NotifyIcon.BalloonTipText = text;
            Form1.NotifyIcon.ShowBalloonTip(2000);
        }
    }
}
