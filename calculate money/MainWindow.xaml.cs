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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculate_money
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtCal_Click(object sender, RoutedEventArgs e)
        {
            int income = int.Parse(txtIncome.Text);
            int expense = int.Parse(txtExpense.Text);
            int want = int.Parse(txtWant.Text);
            int result = (want / (income - expense));

            txtday.Text = result.ToString();

        }
    }
}
