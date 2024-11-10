using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace EjersClase.Forms
{
    public partial class AgeCalculatorForm : Form
    {
        public AgeCalculatorForm()
        {
            InitializeComponent();
        }
 
        private void button1_Click_1(object sender, EventArgs e)
        {
            int edad = DateTime.Now.Year - dateTimePicker1.Value.Year;

            DateTime birthday = dateTimePicker1.Value;
            DateTime today = DateTime.Now;

            if (today < birthday.AddYears(edad))
            {
                edad--;
            }

            DateTime nextBirthday = birthday.AddYears(edad + 1);
            int months = 0;
            int days = 0;

            if (nextBirthday.Month == today.Month && nextBirthday.Day == today.Day)
            {
                months = 0;
                days = 0;
            }
            else if (nextBirthday.Month >= today.Month)
            {
                months = nextBirthday.Month - today.Month;
                if (nextBirthday.Day >= today.Day)
                {
                    days = nextBirthday.Day - today.Day;
                }
                else
                {
                    months--;
                    days = DateTime.DaysInMonth(today.Year, today.Month) - today.Day + nextBirthday.Day;
                }
            }
            else
            {
                months = 12 - (today.Month - nextBirthday.Month);
                if (nextBirthday.Day >= today.Day)
                {
                    days = nextBirthday.Day - today.Day;
                }
                else
                {
                    months--;
                    days = DateTime.DaysInMonth(today.Year, today.Month) - today.Day + nextBirthday.Day;
                }
            }

            label1.Text = $"Edad: {edad}";
            label2.Text = $"Su proximo cumple es en {months} meses y {days} dias";
        }

        
        
    }
}
