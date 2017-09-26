using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace App1
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class BlankPage4 : Page
    {
    public int myProperty { get; set; }
        public BlankPage4()
        {
            this.InitializeComponent();
        }

        private async void Button_ClickAsync(object sender, RoutedEventArgs e)
        {
            var msg = new MessageDialog("Hallo Welt");
            msg.Title = "Titel22";
            msg.Commands.Add(new UICommand("Cancel", new UICommandInvokedHandler(MyCallBack)));
            msg.Commands.Add(new UICommand("OK", new UICommandInvokedHandler(MyCallBack)));
            msg.Commands.Add(new UICommand("demo",(cmd)=>Text1.Text="Lambda"));
            msg.DefaultCommandIndex = 1;
            msg.Options = MessageDialogOptions.AcceptUserInputAfterDelay;
            
            await msg.ShowAsync();
            

        }
        private void MyCallBack(IUICommand cmd)
        {
            if (cmd.Label=="OK")
            { Text1.Text = "gekauft"; }
            else
            {    Text1.Text = "myCallBack";}
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Helper.MessageBox1("Hallo Welt", "Title");
        }
    }
}
