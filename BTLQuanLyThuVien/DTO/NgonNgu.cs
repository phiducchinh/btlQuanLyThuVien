using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLQuanLyThuVien.DTO
{
    public class NgonNgu
    {
        string maNgonNgu;
        string tenNgonNgu;

        public NgonNgu(string maNgonNgu, string tenNgonNgu)
        {
            this.MaNgonNgu = maNgonNgu;
            this.TenNgonNgu = tenNgonNgu;
        }

        public NgonNgu(DataRow row)
        {
            this.MaNgonNgu = row["MaNgonNgu"].ToString();
            this.TenNgonNgu = row["TenNgonNgu"].ToString();
        }

        public string MaNgonNgu
        {
            get
            {
                return maNgonNgu;
            }

            set
            {
                maNgonNgu = value;
            }
        }

        public string TenNgonNgu
        {
            get
            {
                return tenNgonNgu;
            }

            set
            {
                tenNgonNgu = value;
            }
        }
    }
}
