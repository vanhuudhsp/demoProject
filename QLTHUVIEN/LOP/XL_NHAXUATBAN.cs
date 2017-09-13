﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
namespace QLTHUVIEN.LOP
{
    class XL_NHAXUATBAN: XL_BANG 
    {
        #region Các hàm khởi tạo
        public XL_NHAXUATBAN():base("NHAXUATBAN"){}
        public XL_NHAXUATBAN(string pChuoi_SQL): base("NHAXUATBAN", pChuoi_SQL){}
        #endregion
        #region Các hàm xử lý sự kiện
        public void Tim(DataRow p_Dong_dieu_kien)
        {
            string chuoi_DK = "";
            ArrayList mang_DK = new ArrayList();
            if (p_Dong_dieu_kien["MaNXB"] !=null )
                mang_DK.Add("MaNXB LIKE '*"+ p_Dong_dieu_kien["MaNXB"] + "*'"); 
            if (p_Dong_dieu_kien["TenNXB"] !=null )
                mang_DK.Add("TenNXB LIKE '*"+ p_Dong_dieu_kien["TenNXB"] + "*'"); 
          
            if (mang_DK.Count >0)
            {
                for(int i =0; i<mang_DK.Count; i++)
                    if (i == 0) chuoi_DK = mang_DK[i].ToString();
                    else chuoi_DK += " AND " + mang_DK[i];
            }
            Loc_du_lieu(chuoi_DK);
       }
        #endregion 
    }
}
