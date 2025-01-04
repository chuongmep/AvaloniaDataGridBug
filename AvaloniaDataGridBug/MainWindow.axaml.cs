using System.Collections.Generic;
using Avalonia.Controls;

namespace AvaloniaDataGridBug;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        // create data dummy for datagrid 
        var data = new List<DataGridSource>
        {
            new DataGridSource {IsSelected = false, Name = "Name 1"},
            new DataGridSource {IsSelected = false, Name = "Name 2"},
            new DataGridSource {IsSelected = false, Name = "Name 3"},
            new DataGridSource {IsSelected = false, Name = "Name 4"},
            new DataGridSource {IsSelected = false, Name = "Name 5"},
            new DataGridSource {IsSelected = false, Name = "Name 6"},
            new DataGridSource {IsSelected = false, Name = "Name 7"},
            new DataGridSource {IsSelected = false, Name = "Name 8"},
            new DataGridSource {IsSelected = false, Name = "Name 9"},
            new DataGridSource {IsSelected = false, Name = "Name 10"},
        };
        // set data to datagrid
        DataGrid.ItemsSource = data;
    }
    
    public class  DataGridSource
    {
        public bool IsSelected { get; set; }
        public string Name { get; set; }
    }
}