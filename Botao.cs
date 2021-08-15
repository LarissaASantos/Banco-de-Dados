using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;

namespace A6LP2
{
    class Botao
    {
        [PrimaryKey, AutoIncrement]     
        public string PressMeButton_Pressed { get; set; }
        public string PressMeButton_Clicked { get; set; }
    }
}
