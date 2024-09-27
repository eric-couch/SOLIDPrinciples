using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.S;

public class UserService
{
    public void Register(User user)
    {
        // Need to check if the user exists

        // Add user to users

        // Send an email notification
        EmailSender emailSender = new EmailSender();
        emailSender.SendEmail("Welcome to the store.", user.Email);
    }
}
