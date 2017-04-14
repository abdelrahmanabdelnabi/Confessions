using System;
using System.Collections.Generic;
using System.Text;
using UI.Abstractions;

namespace UI.Models
{
    public class TodoItem : TableData
    {
        public string Text { get; set; }
        public string signature { get; set; }
        public string Categories { get; set; }
    }



}
