using System;

namespace Notepad.Model
{
    /// <summary>
    /// Class contain document info and content
    /// </summary>
    public class DocModel : ObservObj
    {
        /// <summary>
        /// This field contains content
        /// </summary>
        private String _text;
        public String Text
        {
            get { return _text; }
            set { OnPropertyChanged(ref _text, value); }
        }

        /// <summary>
        /// Contain path to file
        /// </summary>
        private String _filePath;
        public String FilePath
        {
            get { return _filePath; }
            set { OnPropertyChanged(ref _filePath, value); }
        }

        /// <summary>
        /// Contain name of file
        /// </summary>
        private String _fileName;
        public String FileName
        {
            get { return _fileName; }
            set { OnPropertyChanged(ref _fileName, value); }
        }

        /// <summary>
        /// Method check if we work with new file or not 
        /// </summary>
        public bool isEmpty
        {
            get
            {
                return (String.IsNullOrEmpty(FileName) || String.IsNullOrEmpty(FilePath));
            }
        }
    }
}