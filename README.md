# SfRating getting started
This sample helps to getting started with SfRating control
# Creating project
Below section provides detailed information to create new project in Visual Studio to display SfRating control.

# Adding control via designer
The SfRating control can be added to the application by dragging it from Toolbox and dropping it in designer. The required assembly will be added automatically.

# Adding control manually in XAML
In order to add SfRating control manually in XAML, do the below steps,

 1. Add the below required assembly references to the project,

      * Syncfusion.SfShared.WPF
       * Syncfusion.SfInput.WPF

 2. Import Syncfusion WPF schema http://schemas.syncfusion.com/wpf in XAML page.

3. Declare SfRating in XAML page.

**[XAML]**

```  
    <Grid>
        <syncfusion:SfRating ItemsCount="5" Width="150"/>
    </Grid>
```

# Add control manually in C#

In order to add SfRating control manually in C#, do the below steps,

1. Add the below required assembly references to the project,

    * Syncfusion.SfShared.WPF
    * Syncfusion.SfInput.WPF

2. Import SfRating namespace Syncfusion.Windows.Controls.Input.

3. Create SfRating control instance and add it to window.

**[C#]**

```
 public MainWindow()
{
    InitializeComponent();             
    SfRating newrating = new SfRating()
    {
        ItemsCount = 5,
        Width = 150
    };           
    this.Content = rating;
}
```