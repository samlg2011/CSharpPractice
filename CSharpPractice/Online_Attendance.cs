using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Attendance
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterName ename = new EnterName();
            ename.ev_BannedUser += WarningAlarm;
            ename.User();
            Console.Read();
        }
        static void WarningAlarm(object sender, BannedUserEventArgs e)
        {
            Console.WriteLine("{0} Users Found. Sending Email to Administration.", e.Name);
            Console.WriteLine("Email Sent.");
            Console.WriteLine("Warning Alarm Started.");
            Console.WriteLine("Press Ctrl + c to stop the alarm");
            for (;;)
            {
                Console.Beep();
                System.Threading.Thread.Sleep(100);
            }
        }
    }

    public class EnterName
    {
        public event EventHandler<BannedUserEventArgs> ev_BannedUser;
        public void User()
        {
            Console.Write("Enter You Name : ");
            string user = Console.ReadLine();

            if ((user == "Jack" || user == "Steven" || user == "Mathew") && (ev_BannedUser != null))
            {
                ev_BannedUser(this, new BannedUserEventArgs(user));
            }
            else
            {
                Console.WriteLine("Welcome to " + user);
            }
        }
    }

    public class BannedUserEventArgs : EventArgs
    {
        public BannedUserEventArgs(string s)
        {
            Name = s;
        }
        public string Name { get; set; }
    }
}