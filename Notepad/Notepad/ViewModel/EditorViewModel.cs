using System.Windows.Input;
using Notepad.Model;
using Notepad.Views;

namespace Notepad.ViewModel
{
    /// <summary>
    /// Class contain commands for Font Dialog view
    /// </summary>
    public class EditorViewModel
    {
        #region Parameters
        public ICommand FormatCommand { get; }
        public ICommand WrapCommand { get; }
        public FormModel Format { get; set; }
        public DocModel Document { get; set; }
        #endregion

        /// <summary>
        /// Initialize commands, documents, and fonts 
        /// </summary>
        /// <param name="doc"> Contain document information</param>
        public EditorViewModel(DocModel doc)
        {
            Document = doc;
            Format = new FormModel();
            FormatCommand = new RelayCommand(OpenStyleDialog);
            WrapCommand = new RelayCommand(ToggleWrap);
        }

        /// <summary>
        /// Method for Open Dialog command
        /// </summary>
        private void OpenStyleDialog()
        {
            var fontDialog = new FontDialog();
            fontDialog.DataContext = Format;
            fontDialog.ShowDialog();
        }

        /// <summary>
        /// Toggle Wrap / NoWrap
        /// </summary>
        private void ToggleWrap()
        {
            if (Format.Wrap == System.Windows.TextWrapping.Wrap)
                Format.Wrap = System.Windows.TextWrapping.NoWrap;
            else
                Format.Wrap = System.Windows.TextWrapping.Wrap;
        }
    }
}