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

## How to run this application?

To run this application, you need to first clone the 
SfRating-getting-started repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.