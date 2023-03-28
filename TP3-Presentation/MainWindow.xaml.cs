using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TP3_Logic;


namespace TP3_Presentation
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ValidateText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,]+");
            string currentText = ((TextBox)sender).Text;
            string proposedText = currentText.Substring(0, ((TextBox)sender).SelectionStart) + e.Text + currentText.Substring(((TextBox)sender).SelectionStart + ((TextBox)sender).SelectionLength);
            int countCommas = proposedText.Count(c => c == ',');
            e.Handled = regex.IsMatch(e.Text) || countCommas > 1;
        }

        private void Exercise1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double value = double.Parse(Dividend.Text);
                string result = value.DivisionBy(double.Parse(Divider.Text)); //(Aplicando el concepto de Extension Method)
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepción: " + ex.Message);
            }
        }

        private void Exercise2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double dividend = double.Parse(Dividend.Text);
                double divider = double.Parse(Divider.Text);
                if (divider == 0) throw new DivideByZeroException();
                double result = dividend / divider;
                MessageBox.Show("El resultado es: " + result);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Solo Chuck Norris divide por cero!");
            }
            // Si no tuviera el método ValidateText para una aplicación de consola podría usar el siguiente catch
            catch (FormatException)
            {
                MessageBox.Show("Seguro ingresó una letra o no ingresó nada!");
            }
        }

        private void Exercise3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Logic logic = new Logic();
                logic.Exercise3();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepción del tipo " + ex.GetType().Name + ": " + ex.Message);
            }
        }

        private void Exercise4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                throw new MyCustomException("Este es el mensaje personalizado");
            }
            catch (MyCustomException ex)
            {
                MessageBox.Show("Ha ocurrido una excepción personalizada: " + ex.Message);
            }
        }
    }
}
