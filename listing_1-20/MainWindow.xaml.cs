﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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

namespace listing_1_20
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
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string content = " ";
            try
            {

                HttpClient httpClient = new HttpClient();
                 content = await httpClient
                .GetStringAsync("http://perfect4all.com")
                .ConfigureAwait(true);
                //Output.Text = content;
                using (FileStream sourceStream = new FileStream("temp.html",
FileMode.Create, FileAccess.Write, FileShare.None,
4096, useAsync: true))
                {
                    byte[] encodedText = Encoding.Unicode.GetBytes(content);
                    await sourceStream.WriteAsync(encodedText, 0, encodedText.Length)
                    .ConfigureAwait(true);
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
