using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.S;

public class EmailSender
{
    public void SendEmail(string message, string recipient)
    {
        Console.WriteLine($"Sending email to {recipient}: {message}");
    }
}
