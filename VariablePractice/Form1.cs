using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablePractice
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "";

        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            String playerName = "Wanye Gretzky";
            int playerNumber = 99;
            outputLabel.Text += $"\n{playerName} is number {playerNumber}";
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void payButton_MouseClick(object sender, MouseEventArgs e)
        {
            double hours = 25;
            double pay = 18.75;
            double earned = hours * pay;
            outputLabel.Text += $"\n{hours} hours at {pay} per hours equals {earned}";
        }

        private void circleButton_MouseClick(object sender, MouseEventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = radius * radius * pi;
            outputLabel.Text += $"\nThe area of a circle with a radius of {radius}cm is {area}cm^2";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMetre = 19.95;
            double areaCarpet = length * width;
            double totalCost = length * width * costPerMetre;
            outputLabel.Text += $"\nThe area of a room with dimensions {length}m x {width}m is {areaCarpet}m^2";
            outputLabel.Text += $"\nThe cost to carpet this area is ${costPerMetre} per square metre is ${totalCost}";
        }

        private void billButton_MouseClick(object sender, MouseEventArgs e)
        {
            double shirt = 12.49;
            double money = 20.00;
            double tax = 0.13;
            double taxAmount = tax * shirt;
            double totalCost = taxAmount + shirt;
            double change = money - totalCost;

           
            outputLabel.Text += $"\nBill of Sale";
            outputLabel.Text += $"\n\nShirt:          ${shirt}";
            outputLabel.Text += $"\nTax:            ${taxAmount}";
            outputLabel.Text += $"\nTotal:          ${totalCost}";
            outputLabel.Text += $"\n\nTendered:       ${money}.00";
            outputLabel.Text += $"\n\nChange:         ${change}";
        }
    }
}