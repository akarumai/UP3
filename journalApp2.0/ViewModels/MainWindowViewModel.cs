using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using journalApp2._0.ViewModels.Base;

namespace journalApp2._0.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string title="УП наше крутое";
        /// <summary>
        /// Заголовок окна 
        /// </summary>
        public string Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }
    }
}
