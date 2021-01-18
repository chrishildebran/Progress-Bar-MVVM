// ///////////////////////////////////////////////////////////
// Company:............. Sheasta Development
// Website:............. http://www.sheasta.com
// Solution:............ Progress Bar Test 30
// Project:............. ProgressBar
// File:................ MainWindowViewModel.cs
// Last Code Cleanup:... 01/18/2021 @ 1:25 PM Using ReSharper
// Review Comment:...... // ✓✓ 01/18/2021 - Review Comment:
// ///////////////////////////////////////////////////////////

namespace ProgressBar.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.CommandWpf;
    using ProgressBar.Models;
    using ProgressBar.Properties;
    using Telerik.Windows.Controls;

    internal class MainWindowViewModel : ViewModelBase
    {
        #region Fields (All)

        private double currentProgress = 12.1;

        private List<ValveModel> valveModels;

        #endregion

        #region Constructors (All)

        public MainWindowViewModel()
        {
            this.valveModels = new List<ValveModel>();

            for (var i = 0; i < 123; i++)
            {
                this.valveModels.Add(new ValveModel($"Model Number {i}"));
            }

            this.CommandCalibrate = new RelayCommand<RadProgressBar>(this.Calibrate);
        }

        #endregion

        #region Events (All)

        public new event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Properties (Non-Private)

        public ICommand CommandCalibrate { get; set; }

        public double CurrentProgress
        {
            get { return this.currentProgress; }
            set
            {
                this.currentProgress = value;
                this.OnPropertyChanged();
            }
        }

        #endregion

        #region Properties (Private)

        private int ValvesCalibrated { get; set; }

        #endregion

        #region Methods (Non-Private)

        [NotifyPropertyChangedInvocator]
        public new void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Methods (Private)

        private void Calibrate(RadProgressBar bar)
        {
            this.DoWork(bar).FireAndForgetSafeAsync();
        }

        private async Task DoWork(RadProgressBar bar)
        {
            await Task.Run(() =>
                           {
                               foreach (var valveModel in this.valveModels)
                               {
                                   // Calibrate Valve

                                   // Increment Property
                                   this.ValvesCalibrated++;

                                   if (this.ValvesCalibrated != 0)
                                   {
                                       //This line just slows things down so you can see it remove for production stuff
                                       Thread.Sleep(10);
                                       bar.Dispatcher.Invoke(() => bar.Value = 100.0 * this.ValvesCalibrated / this.valveModels.Count);
                                   }
                               }

                               MessageBox.Show($"A total of {this.ValvesCalibrated} out of {this.valveModels.Count} valve were calibrated", "Message Box");
                           });
        }

        #endregion
    }
}