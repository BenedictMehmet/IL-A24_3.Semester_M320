using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_3.Semester_M320.KW38_25
{
    internal class Polymorphism2
    {
        static void Main(string[]args)
        {
            IPaymentProcessor creditCard = new CreditCardProcessor();

            PaymentService py = new PaymentService(creditCard);

            py.ProcessOrderPayment(100.00m);


            IPaymentProcessor paypal = new PayPalProcessor();

            PaymentService py2 = new PaymentService(paypal);

            py2.ProcessOrderPayment(200.00m);


            // Ich will mit Twint zahlen. Wass muss programmiert werden?


        }
    }





    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }


    // Erstelle zwei Klassen CreditCardProcessor und PayPalProcessor.
    // Übergebe das Interface als abgeleitete Klasse und verwende die Methode ProcessPayment

    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card Payment in {amount}");

            Console.WriteLine("Processing Credit Card Payment in" + amount);
        }
    }



    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card Payment in {amount}");
        }
    }


    public class PaymentService
    {
        private readonly IPaymentProcessor _processor;
        

        public PaymentService(IPaymentProcessor processor)
        {
            this._processor = processor;
        }

        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }

    }

}
