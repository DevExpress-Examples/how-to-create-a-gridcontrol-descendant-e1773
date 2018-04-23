using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpo;
using System.ComponentModel;
using DevExpress.Xpf.Grid;
using DevExpress.Data.Filtering;

namespace WpfApplication1 {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
       List<ContactItem> coll;
        public Window1() {
            InitializeComponent();
            coll = new List<ContactItem>();

            ContactItem f1 = new ContactItem();
                f1.Name  = "A";
                f1.Salary = 200;
                coll.Add(f1);
                ContactItem f2 = new ContactItem();
                f2.Name = "B";
                f2.Salary = 100;
                coll.Add(f2);
            
            gridControl1.ItemsSource = coll;

        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            gridControl1.FilterCriteria = 
    new BinaryOperator("Salary", 100, BinaryOperatorType.Greater );
        }

    }
}
