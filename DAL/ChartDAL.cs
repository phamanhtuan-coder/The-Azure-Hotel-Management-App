using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChartDAL
    {
        public List<ChartDTO> LoadChart()
        {
            try
            {
                List<ChartDTO> chartData = new List<ChartDTO>();
                DateTime currentDate = DateTime.Now;
                for (int i = 0; i < 7; i++)
                {
                    SqlConnection conn = DataProvider.KetNoiDuLieu();
                    conn.Open();

                    SqlCommand com = new SqlCommand("spTongGiaDichVu", conn);
                    com.CommandType = System.Data.CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Ngay", currentDate.AddDays(-i));
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read()) 
                    {
                        ChartDTO chart = new ChartDTO();
                        chart.Ngay = currentDate.AddDays(-i);
                        chart.TongGiaDichVu = (decimal) reader["TongGiaDichVu"];
                        chart.TongGiaPhong = (decimal)reader["TongGiaPhong"];
                        chartData.Add(chart);
                    }

                    conn.Close();
                }
                return chartData;
            }
            catch (Exception)
            {
                return new List<ChartDTO>();
            }
        }
    }
}
