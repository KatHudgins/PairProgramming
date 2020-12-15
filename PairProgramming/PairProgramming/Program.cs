﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
                        /* 3. Once the user has successsfully given their account and pin numbers, protmpt the user with a menu and ask them if they want to do a deposit, a withdrawal, or exit the application.*/
            bool repeat = true;
            int accTotal = 0;
            /*
             * ADDITIONAL Optional Features:
                    -Keep a running total of the account balance, assuming that the account starts at $0.
                    -Every time the user makes a deposit to-or withdraw from- the account, the balance should be updated and displayed.
                    -Add a feature for the user to make a balance request that will display their current balance (without needing to make a deposit or withdrawal)
             */
            for (int i = 0; i < 10; i++)
                do
                {
                    Console.Write("\nD)Deposit\nW)Withdrawal\nA)Account Balance\nX)Exit\n");
                    string userChoice = Console.ReadLine().ToUpper();

                    Console.Clear();
                    switch (userChoice)
                    {
                        /*4.If they choose to do a deposit, ask them for the amount to deposit, and display the amount deposited.
                            a) ex. "$500.00 has been deposited into account number 12345"*/
                        case "D":
                        case "DEPOSIT":
                            Console.Write("Enter the amount you wish to DEPOSIT: ");
                            int userDeposit = Convert.ToInt32(Console.ReadLine());
                            Console.Write("You have chosen to deposit: {0:c} into account number 85345682.", userDeposit);
                            accTotal = accTotal + userDeposit;
                            Console.Write("\nYour account balance is Currently: {0:c}", accTotal);
                            break;
                        /* 5. If they choose to withdraw money, ask them for the amount to withdraw and display the amount being withdrawn.
                             a) ex. "$500.00 has been withdrawn from from the following account:#12345"*/
                        case "W":
                        case "WITHDRAWAL":
                            Console.Write("Enter the amount you wish to WITHDRAWAL: ");
                            int userWithdrawal = Convert.ToInt32(Console.ReadLine());
                            accTotal = accTotal - userWithdrawal;
                            Console.Write("\nYou have chosen to withdrawal: {0:c} from account number 85345682.", userWithdrawal);
                            if (accTotal >= userWithdrawal)
                            {
                                Console.Write("\nPlease collect desired cash back: {0:c}", userWithdrawal);
                                Console.Write("\nYou're new balance is: {0:c}", accTotal);
                            }
                            else
                                Console.Write("\nYour account does not have sufficient balance");
                            break;
                        case "A":
                        case "ACCOUNT BALANCE":
                            Console.Write("Your account balance is Currently: {0:c}", accTotal);
                            break;
                        /* 7. When the user exits the application, thank them for their business.*/
                        case "X":
                        case "E":
                        case "EXIT":
                            Console.Write("\nI hope I was able to satisfy your ATM needs. See ya next time around!\n");
                            repeat = false;
                            return;
                        default:
                            Console.Write("\nThere seems to be a miscommunication, try another attempt\n");
                            break;


                    }
                    /*6. After each transaction (deposit or withdrawl) ask the user if they want to do another deposit/withdrawal, or exit the application.*/
                } while (repeat);

        }
    }
}
