using System;
using System.IO;
using System.Windows.Input;
using Microsoft.Win32;
using Notepad.Model;

namespace Notepad.ViewModel
{
    /// <summary>
    /// Class contain commands for menu point 'File'
    /// </summary>
    public class FileViewModel
    {
        /// <summary>
        /// Contain commands
        /// </summary>
        #region Commands
        public ICommand NewCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand SaveAsCommand { get; }
        public ICommand OpenCommand { get; }
        public ICommand CloseCommand { get; }
        #endregion

        /// <summary>
        /// Element contain document information
        /// </summary>
        public DocModel Document { get; private set; }

        /// <summary>
        /// Constructor, initialize commands and document class
        /// </summary>
        /// <param name="document">Class contain document info and content</param>
        public FileViewModel(DocModel document)
        {
            Document = document;
            NewCommand = new RelayCommand(NewFile);
            SaveCommand = new RelayCommand(SaveFile);
            SaveAsCommand = new RelayCommand(SaveFileAs);
            OpenCommand = new RelayCommand(OpenFile);
            CloseCommand = new RelayCommand(CloseProgram);
        }

        /// <summary>
        /// Initialize new Document
        /// </summary>
        public void NewFile()
        {
            Document.FileName = String.Empty;
            Document.FilePath = String.Empty;
            Document.Text = String.Empty;
        }

        /// <summary>
        /// Method for Save File command
        /// </summary>
        public void SaveFile()
        {
            File.WriteAllText(Document.FilePath, Document.Text);
        }

        /// <summary>
        /// Method for Save File As command
        /// </summary>
        public void SaveFileAs()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt";
            if(saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, Document.Text);
            }
        }

        /// <summary>
        /// Method for Open File command
        /// </summary>
        public void OpenFile()
        {
            var openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == true)
            {
                DockFile(openFileDialog);
                Document.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }


        /// <summary>
        /// Method for File Dialog
        /// </summary>
        /// <typeparam name="T">Generic Type Parameter</typeparam>
        /// <param name="dialog">Dialog object</param>
        public void DockFile<T>(T dialog) where T : FileDialog
        {
            Document.FilePath = dialog.FileName;
            Document.FileName = dialog.SafeFileName;
        }

        /// <summary>
        /// Method for Close command
        /// </summary>
        private void CloseProgram()
        {
            Environment.Exit(0);
        }
    }
}