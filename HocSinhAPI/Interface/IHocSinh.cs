using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HocSinhAPI.Entities;

namespace HocSinhAPI.Interface
{
    public interface IHocSinh
    {
        public HocSinh ThemHocSinh(int lopid, HocSinh hs);
    }
}
