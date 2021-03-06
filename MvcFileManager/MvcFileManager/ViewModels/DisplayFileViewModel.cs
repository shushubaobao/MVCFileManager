﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcFileManager.ViewModels
{
    public class DisplayFileViewModel
    {
        public string FileName { get; set; }

        public string Creater { get; set; }

        public int Version { get; set; }

        public DateTime UploadTime { get; set; }

        public DateTime ModifiedTime { get; set; }

        public string FileContent { get; set; }
    }
}