﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soundpacking
{
    class AudioFile
    {
        //Audio File class from which the arrays will be created to hold 2 data members name & Duaration

        private string FileName;
        private int Duration;

        public void SetFileName(string FileName) {
            this.FileName = FileName;
        }

        public string GetFileName() {
            return this.FileName;
        }

        public void SetDuration(int Duration) {
            this.Duration = Duration;
        }

        public int GetDuation() {
            return this.Duration;
        }
    }
}
