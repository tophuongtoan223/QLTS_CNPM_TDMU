﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private static DTO_KhachHang instance;

        public static DTO_KhachHang Instance
        {
            get { if (instance == null) instance = new DTO_KhachHang(); return instance; }
            private set { instance = value; }
        }
        private DTO_KhachHang() { }
        public DTO_KhachHang(string tenkH, string sdt)
        {
            this.tenkH = tenkH;
            this.sdt = sdt;
        }
        private string tenkH;
        private string sdt;

        public string TenkH { get => tenkH; set => tenkH = value; }
        public string Sdt { get => sdt; set => sdt = value; }

    }
}
