using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App7
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public class Reminder
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Time { get; set; }
        public bool IsActive { get; set; }
    }
    public sealed partial class MainPage : Page
    {
        public List<Reminder> Reminders;
        public MainPage()
        {
            this.InitializeComponent();
            Reminders = new List<Reminder>();

            Reminders.Add(new Reminder { ID = 1, Name = "todd", Time = "12.16pm", IsActive = true });
            Reminders.Add(new Reminder { ID = 2, Name = "todd", Time = "12.16pm", IsActive = true });
            Reminders.Add(new Reminder { ID = 3, Name = "todd", Time = "12.16pm", IsActive = true });
            Reminders.Add(new Reminder { ID = 4, Name = "todd", Time = "12.16pm", IsActive = true });
            Reminders.Add(new Reminder { ID = 5, Name = "todd", Time = "12.16pm", IsActive = true });



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = null;


            /*    Reminders.Add(new Reminder { ID = 100, Name = "gfdgtodd", Time = "12.16pm", IsActive = true });*/
            datagrid.ItemsSource = Reminders;


        }

        /*xaml fires this when generatin colum , which then enables you to cancel colums and or rename them*/
        void DG1_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            string headername = e.Column.Header.ToString();

            //Cancel the column you don't want to generate
            if (headername == "ID")
            {
                e.Cancel = true;
            }

            //update column details when generating
            if (headername == "FirstName")
            {
                e.Column.Header = "First Name";
            }
            else if (headername == "LastName")
            {
                e.Column.Header = "Last Name";
            }
            else if (headername == "EmailAddress")
            {
                e.Column.Header = "Email";
            }
        }


        int index;

        int index3;
        int index4;


        private void Datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                textblock4.Text = Reminders[datagrid.SelectedIndex].Name;
                textblock3.Text = datagrid.SelectedIndex.ToString();
            }
            catch
            {
                textblock4.Text = "";
            }
            /*  index4 = 0;
            index = datagrid.SelectedIndex;
      
       
            index4 = index+1;
            showimage();*/

            /*       textblock4.Text = Reminders[index].Name;*/

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            /*          string Time = Reminders[datagrid.SelectedIndex].Time;
                        int ID = Reminders[datagrid.SelectedIndex].ID;
                        bool IsActive = Reminders[datagrid.SelectedIndex].IsActive;*/

            textblock.Text = index.ToString();

            textblock3.Text = index3.ToString();
            textblock4.Text = index4.ToString();


            /*      Reminders.Add(new Reminder { ID = 7, Name = Name, Time = "dsad", IsActive = false });*/




            /*   int dgindx = datagrid.SelectedIndex;*/

            /*            string Name = Reminders[datagrid.SelectedIndex].Name;
                        string Time = Reminders[datagrid.SelectedIndex].Time;
                        int ID = Reminders[datagrid.SelectedIndex].ID;
                        bool IsActive = Reminders[datagrid.SelectedIndex].IsActive;

                        *//*do Code here*//*
                        Reminders.Add(new Reminder { ID = ID , Name = Name, Time = Time, IsActive = IsActive });
                        datagrid.ItemsSource = null;
                        datagrid.ItemsSource = Reminders;*/

        }
        private void showimage()
        {
            textblock.Text = index.ToString();

            textblock3.Text = index3.ToString();
            textblock4.Text = index4.ToString();
        }

    }
}
