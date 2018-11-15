<!-- default file list -->
*Files to look at*:

* [CustomControl1.cs](./CS/MyGridControl/CustomControl1.cs) (VB: [CustomControl1.vb](./VB/MyGridControl/CustomControl1.vb))
* [Customer.cs](./CS/WpfApplication1/Customer.cs) (VB: [Customer.vb](./VB/WpfApplication1/Customer.vb))
* [Window1.xaml](./CS/WpfApplication1/Window1.xaml) (VB: [Window1.xaml.vb](./VB/WpfApplication1/Window1.xaml.vb))
* [Window1.xaml.cs](./CS/WpfApplication1/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/WpfApplication1/Window1.xaml.vb))
<!-- default file list end -->
# How to create a GridControl descendant


<p>You should inherit from the GridControl, override the necessary method, and embed this custom GridControl into your xaml. This sample illustrates how to override the OnPropertyChanged method to be notified that the FilterCriteria property has been changed.</p>

<br/>


