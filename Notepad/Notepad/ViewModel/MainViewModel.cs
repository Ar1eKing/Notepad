using Notepad.Model;

namespace Notepad.ViewModel
{
    public class MainViewModel 
    {
        #region Parameters
        private DocModel _document;
        public EditorViewModel Editor { get; set; }
        public FileViewModel File { get; set; }
        public HelpViewModel Help { get; set; }
        #endregion

        /// <summary>
        /// Initialize all parameters in constructor
        /// </summary>
        public MainViewModel()
        {
            _document = new DocModel();
            _document.FilePath = "New File.txt";
            Help = new HelpViewModel();
            Editor = new EditorViewModel(_document);
            File = new FileViewModel(_document);
        }
    }
}