// ///////////////////////////////////////////////////////////
// Company:............. Sheasta Development
// Website:............. http://www.sheasta.com
// Solution:............ Progress Bar Test 30
// Project:............. ProgressBar
// File:................ MainWindow.xaml.cs
// Last Code Cleanup:... 01/18/2021 @ 1:25 PM Using ReSharper
// Review Comment:...... // ✓✓ 01/18/2021 - Review Comment:
// ///////////////////////////////////////////////////////////

namespace ProgressBar.Views
{
    using System.Windows;
    using ProgressBar.ViewModels;

    public partial class MainWindow : Window
    {
        #region Constructors (All)

        public MainWindow()
        {
            this.InitializeComponent();

            this.DataContext = new MainWindowViewModel();
        }

        #endregion
    }
}