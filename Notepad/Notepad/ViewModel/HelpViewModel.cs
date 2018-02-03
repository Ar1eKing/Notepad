using Notepad.Views;
using System.Windows.Input;

namespace Notepad.ViewModel
{
    /// <summary>
    /// Class contain commands for menu point 'Help'
    /// </summary>
    public class HelpViewModel : ObservObj
    {
        #region Parameters
        public ICommand AboutCommand { get; }
        private string _aboutInfo;
        public string AboutInfo
        {
            get { return _aboutInfo; }
            set { OnPropertyChanged(ref _aboutInfo, value); }
        }
        #endregion

        /// <summary>
        /// Initialize commands and parameters
        /// </summary>
        public HelpViewModel()
        {
            AboutCommand = new RelayCommand(DisplayAbout);
            AboutInfo = "Program created By VAlex";
        }

        /// <summary>
        /// Method create and show About Dialog
        /// </summary>
        private void DisplayAbout()
        {
            var aboutDialog = new AboutDialog();
            aboutDialog.ShowDialog();
        }
    }
}