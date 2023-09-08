﻿using CodeFirst.Enums;

namespace CodeFirst.DataModels
{
    public class Class
    {
        public int  ClassID { get; set; }
        public string ClassName { get; set; }
        public int MaxClassSize { get; set; }

        public Language ClassLanguage { get; set; }
    } 
}