﻿using System.Windows.Controls;
using System.Windows;

namespace Hospital
{
    public partial class PatientPersonalAccount : Page
    {
        public PatientPersonalAccount()
        {
            InitializeComponent();            
            Surname.Text = VariableClass.Surname;
            Name.Text = VariableClass.Name;
            Patronymic.Text = VariableClass.Patronymic;
        }

        public void HospitalizationButton(object sender, RoutedEventArgs e)
        {
            Manager.myFrame.Navigate(new Hospitalization());
        }

        public void ExitButton(object sender, RoutedEventArgs e)
        {
            Manager.myFrame.Navigate(new Main());
        }
    }
}
