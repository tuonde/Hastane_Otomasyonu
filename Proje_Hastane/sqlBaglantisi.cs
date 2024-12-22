using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proje_Hastane
{
    internal class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=TUNAHAN;Initial Catalog=HastaneProje;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }
    }
}
