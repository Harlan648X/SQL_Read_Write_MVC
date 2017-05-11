using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQL_Read_Write_MVC.Models
{
    public class RecordInfo
    {
        public string Input { get; set; }
        public DateTime DayTime { get; set; }
    }

    public class RecordModel
    {
        public bool IsSecretWord { get; set; }
        public List<RecordInfo> WordList { get; set; }

        public RecordModel() //Constructor to give initial value to IsSecretWord and initialize the list
        {
            IsSecretWord = false;
            WordList = new List<RecordInfo>();
        }
    }

}