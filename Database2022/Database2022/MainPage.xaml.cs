﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Database2022
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PersonService service = new PersonService();
            List<Person> people = new List<Person>();

            for (int i = 0; i < 3; i++)
            {
                people.Add(new Person
                {
                    LastName = txtLastName.Text,
                    FirstName = txtName.Text,
                    Fecha = datePickerFecha.Date, // Usar DatePicker
                    Curso = txtCurso.Text,
                    Genero = (string)pickerGenero.SelectedItem // Usar Picker
                });
            }

            service.CreateRange(people);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            PersonService service = new PersonService();
            lvPeople.ItemsSource = service.Get();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            PersonService service = new PersonService();
            lvPeople.ItemsSource = service.GetByText(txtFilter.Text.Trim());
        }
    }
}
