﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationFramework.LanguageFactory;

namespace ValidationFramework
{
    public abstract class Validator
    {
        protected int Code; // Loai code

        public string Message; // Thông báo
        public virtual bool check(string input, LanguageNotification l)
        {
            return true;
        }
    }
}