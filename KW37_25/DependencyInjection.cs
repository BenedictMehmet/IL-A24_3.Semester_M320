using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_3.Semester_M320.KW37_25
{
    internal class DependencyInjection
    {
        static void Main(string[]args)
        {
            IEmailService emailService = new EmailService();
            UserService userService = new UserService(emailService);
            userService.RegisterUser("Max");






        }
    }


    public interface IEmailService
    {
      void SendMail(string message);
    }


    public class EmailService : IEmailService
    {
        public void SendMail(string message)
        {
            Console.WriteLine($"Sending mail: {message}");
        }
    }

    public class SMSService : IEmailService
    {
        public void SendMail(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }



    public class UserService
    {
        private readonly IEmailService _emailService;

        public UserService(IEmailService emailService)
        {
            this._emailService = emailService;
        }

        public void RegisterUser(string name)
        {
            Console.WriteLine($"User {name} registered succesfully.");
            _emailService.SendMail($"Welcome {name}");
        }
    }





}
