using Avalonia.Controls;
using Avalonia.Input;
using System;

namespace FastAnnotationCO.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBoxContent_KeyDown(object? sender, Avalonia.Input.KeyEventArgs e)
        {
            if ((e.KeyModifiers == KeyModifiers.Control))
            {
                
                Console.WriteLine("V");
            }
        }
    }
}