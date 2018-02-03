using System.Windows;
using System.Windows.Media;

namespace Notepad.Model
{
    /// <summary>
    /// Class will contain info about text format
    /// </summary>
    public class FormModel : ObservObj
    {
        /// <summary>
        /// contain font style
        /// </summary>
        private FontStyle _style;
        public FontStyle Style
        {
            get { return _style; }
            set { OnPropertyChanged(ref _style, value); }
        }

        /// <summary>
        /// contain font weight
        /// </summary>
        private FontWeight _weight;
        public FontWeight Weight
        {
            get { return _weight; }
            set { OnPropertyChanged(ref _weight, value); }
        }

        /// <summary>
        /// contain font family
        /// </summary>
        private FontFamily _family;
        public FontFamily Family
        {
            get { return _family; }
            set { OnPropertyChanged(ref _family, value); }
        }

        /// <summary>
        /// contain text wrapping
        /// </summary>
        private TextWrapping _wrap;
        public TextWrapping Wrap
        {
            get { return _wrap; }
            set
            {
                OnPropertyChanged(ref _wrap, value);
                isWrapped = value == TextWrapping.Wrap ? true : false;
            }
        }

        /// <summary>
        /// parameter remember wrapping state
        /// </summary>
        private bool _isWrapped;
        public bool isWrapped
        {
            get { return _isWrapped; }
            set { OnPropertyChanged(ref _isWrapped, value); }
        }

        /// <summary>
        /// contain font size
        /// </summary>
        private double _size;
        public double Size
        {
            get { return _size; }
            set { OnPropertyChanged(ref _size, value); }
        }
    }
}