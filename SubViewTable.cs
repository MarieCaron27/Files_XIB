using System;

using AppKit;
using Foundation;
using vues_table;

namespace file_XIB;

[Register("SubViewTable")]
public partial class SubViewTable : NSViewController
{
    public SubViewTable() : base("SubViewTable", null)
    {
    }

    public override void ViewDidLoad()
    {
        base.ViewDidLoad();

        // Do any additional setup after loading the view.
    }
    
    public override void AwakeFromNib ()
    {
        base.AwakeFromNib ();

        // Create the Product Table Data Source and populate it
        var DataSource = new ProductTableDataSource ();
        DataSource.Products.Add (new Product ("Xamarin.iOS", "Allows you to develop native iOS Applications in C#"));
        DataSource.Products.Add (new Product ("Xamarin.Android", "Allows you to develop native Android Applications in C#"));
        DataSource.Products.Add (new Product ("Xamarin.Mac", "Allows you to develop Mac native Applications in C#"));
        DataSource.Sort ("Title", true);

        // Populate the Product Table
        ProductTableView.DataSource = DataSource;
        ProductTableView.Delegate = new ProductTableDelegate (this,DataSource);

        // Auto select the first row
        ProductTableView.SelectRow (0, false);
    }
    
    public void ReloadTable()
    {
        ProductTableView.ReloadData();
    }
}