using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Calcs {
    public partial  class withoutButt : Window {
        public withoutButt() {
            InitializeComponent();
            value.Focus();
        }

        private void value_TextChanged(object sender, TextChangedEventArgs e) {
            answer.Text = Calc(value.Text);
        }

        private string Calc(String changableValue) {
            String ans;

            try {
                var calc = new NCalc.Expression(changableValue).Evaluate();
                ans = calc.ToString();
                answer.Foreground = Brushes.Gray;

            }
            catch {
                ans = "Не является выражением.";
                answer.Foreground = Brushes.Gray;

            }
            return ans;
        }
    }
}
