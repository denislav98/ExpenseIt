﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Window
    {
        public ExpenseItHome()
        {
            InitializeComponent();
            ListBoxItem james = new ListBoxItem();
            james.Content = "James";
            peopleListBox.Items.Add(james);
            ListBoxItem david = new ListBoxItem();
            david.Content = "David";
            peopleListBox.Items.Add(david);
            ListBoxItem lisa = new ListBoxItem();
            lisa.Content = "Lisa";
            peopleListBox.Items.Add(lisa);


        }

        private void ViewExpenseReportButton(object sender, RoutedEventArgs e)
        {
            string greetingMsg = peopleListBox.SelectedItem.ToString();
            MessageBox.Show("Hi " + greetingMsg);
        }
    }
}
