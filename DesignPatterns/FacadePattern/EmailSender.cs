﻿namespace CodingInterviewSolutions.DesignPatterns.FacadePattern
{
    internal class Email
    {
        public bool SendRegistrationEmail(Customer customer)
        {
            //Send Registration Successful Email to Customer
            Console.WriteLine("\nRegistration Email Send to Customer...");
            return true;
        }
    }
}
