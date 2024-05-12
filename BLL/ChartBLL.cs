using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChartBLL
    {
        ChartDAL chartDTO = new ChartDAL();
        public List<ChartDTO> LoadChart()
        {
            return chartDTO.LoadChart();
        }
    }
}
