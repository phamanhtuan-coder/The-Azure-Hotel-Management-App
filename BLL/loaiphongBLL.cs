﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    
    public class loaiphongBLL
    {
        loaiphongDAL loaiphong = new loaiphongDAL();
        public List<loaiphongDTO> laydslphong()
        {
            return loaiphong.laydsloaiphong();
        }

    }
}
