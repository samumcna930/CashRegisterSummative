using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media; 

namespace CashRegisterSummative
{
    public partial class Form1 : Form
    {
        const double TICKET = 12.00;
        const double POPCORN = 8.99;
        const double DRINK = 3.99;
        const double TAX = 0.13;
        double priceOfDrink;
        double priceOfPopcorn;
        double priceOfTicket;
        double costOfOrder;
        double costOfOrderTotal;
        double tendered;
        double change;
        double taxCost;
        int numbOfTickets;
        int numbOfPopcorns;
        int numbOfDrinks;
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Converting inputs to numbers
                numbOfTickets = Convert.ToInt16(ticketInput.Text);
                numbOfPopcorns = Convert.ToInt16(popcornInput.Text);
                numbOfDrinks = Convert.ToInt16(drinkInput.Text);
            }
            catch {
                messageLabel.Text = "Please enter a vaild amount. ";
                return; 
            }
            //making variables for each item total cost without tax
            priceOfDrink = numbOfDrinks * DRINK;
            priceOfPopcorn = numbOfPopcorns * POPCORN;
            priceOfTicket = numbOfTickets * TICKET;

            //calculating total price of all items combined
            costOfOrder = priceOfDrink + priceOfPopcorn + priceOfTicket;

            //calculating the tax for the entire order
            taxCost = costOfOrder * TAX;
            //calculating the total price for the entire order with tax
            costOfOrderTotal = costOfOrder + taxCost;

            //outputting the costs to the labels
            subTotalOutput.Text = costOfOrder.ToString("C");
            taxOutput.Text = taxCost.ToString("C");
            totalOutput.Text = costOfOrderTotal.ToString("C");
       


        }

        private void CalculateChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //converting tendered into a double 
                tendered = Convert.ToDouble(tenderedInput.Text);
                //change calculation
                change = tendered - costOfOrderTotal;
                //if calculation prevents customer from giving invalid amount of tendered 
                if ( tendered < costOfOrderTotal )
                { messageLabel.Text = "Please enter a vaild amount. ";
                    change = 0; 
                }
            }
            catch { messageLabel.Text = "Please enter a vaild amount. "; }

            //outputs the change to the form 
            changeOutput.Text = change.ToString("C");
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SoundPlayer cashRegister = new SoundPlayer(Properties.Resources.cashRegister);

            
            g.Clear(Color.WhiteSmoke);

            Font drawFont = new Font("Consolas", 11);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            //random numbers for order number and date
            Random monthRng = new Random();
            Random dayRng = new Random();
            Random randGen = new Random();
            int order = randGen.Next(1, 500);
            int day = dayRng.Next(1,28);
            int month = monthRng.Next(1,12);
            
            //cashier sound effect
            cashRegister.Play();

            //title of receipt 
            g.DrawString("McNab Movies Inc.", drawFont, drawBrush, 470, 100);
            Thread.Sleep(200);
            //random date
            g.DrawString(day + "/" + month + "/09", drawFont, drawBrush, 455, 135);
            Thread.Sleep(200);
            //random order number
            g.DrawString("Order # " + order, drawFont, drawBrush, 455, 150);
            Thread.Sleep(200);
            //amount of ticket(s) and total price without tax
            g.DrawString("Ticket            " + "x" + numbOfTickets + "      @" + (numbOfTickets * TICKET).ToString("C"), drawFont, drawBrush, 455, 170);
            Thread.Sleep(200);
            //amount of popcorn(s) and total price without tax
            g.DrawString("\nPopcorn           " + "x" + numbOfPopcorns + "      @" + (numbOfPopcorns * POPCORN).ToString("C"), drawFont, drawBrush, 455, 170);
            Thread.Sleep(200);
            //amount of drink(s) and total price without tax
            g.DrawString("\n\nDrink             " + "x" + numbOfDrinks + "      @" + (numbOfDrinks * DRINK).ToString("C"), drawFont, drawBrush, 455, 170);
            Thread.Sleep(200);
            //total amount of all items together without tax
            g.DrawString("\n\n\nSubtotal                   " + (costOfOrder).ToString("C"), drawFont, drawBrush, 455, 250);
            Thread.Sleep(200);
            //tax amount from the order
            g.DrawString("\n\n\n\nTax                        " + (taxCost).ToString("C"), drawFont, drawBrush, 455, 250);
            Thread.Sleep(200);
            //total amount including tax
            g.DrawString("\n\n\n\n\nTotal                      " + (costOfOrderTotal).ToString("C"), drawFont, drawBrush, 455, 250);
            Thread.Sleep(200);
            //amount customer tendered 
            g.DrawString("\n\n\n\n\n\n\nTendered                   " + (tendered).ToString("C"), drawFont, drawBrush, 455, 300);
            Thread.Sleep(200);
            //amount of change from tendered
            g.DrawString("\n\n\n\n\n\n\n\nChange                     " + (change).ToString("C"), drawFont, drawBrush, 455, 300);
            Thread.Sleep(200);

            g.DrawString("\n\n\n\n\n\n\n\n\nHave a Great Day!",drawFont, drawBrush, 455,300); 



        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            g.Clear(Color.WhiteSmoke);
            //reseting all values to 0 in order to reset order 
            change = 0;
            priceOfDrink = 0;
            priceOfPopcorn = 0;
            priceOfTicket = 0;

            costOfOrder = 0;

            taxCost = 0;
            costOfOrderTotal = 0;
            tendered = 0;

            subTotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";

            numbOfTickets = 0;
            numbOfPopcorns = 0;
            numbOfDrinks = 0;

            ticketInput.Text = "";
            popcornInput.Text = "";
            drinkInput.Text = "";

            changeOutput.Text = "";
            tenderedInput.Text = "";


        }
    }
}
