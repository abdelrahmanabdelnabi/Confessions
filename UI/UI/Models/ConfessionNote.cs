using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using UI.Abstractions;

namespace UI.Models
{
    public class  ConfessionNote : TableData
    {
        
       
        public static ObservableCollection<ConfessionNote> ConfessionsList = new ObservableCollection<ConfessionNote>();
        public string Text { get; set; }
        public string signature { get; set; }
        public string Categories { get; set; }

        public ConfessionNote(string text1, string text2, string selecteditem)
        {
            this.Text = text1;
            this.signature = text2;
            this.Categories = selecteditem;
        }
    }

    


}
