using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Assignment2_DangNgocYenNhi_2190994_DTO;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class PerfumeBLL
    {
        private PerfumeDAO dao = new PerfumeDAO();
        public bool createPerfume(DTO_Perfume perf)
        {
            return dao.insertPerfume(perf);
        }

        public bool updatePerfume(DTO_Perfume perf)
        {
            return dao.updatePerfume(perf);
        }

        public bool deletePerfume(int IdPerfume)
        {
            return dao.deletePerfume(IdPerfume);
        }

        public DataSet getAllPerfume()
        {
            return dao.getAllPerfume();
        }
    }
}