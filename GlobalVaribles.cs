using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCARA_ROBOT_SOFTWARE
{
    public static class GlobalVariables
    {
        public static string? selectedPort = "";
        public static int selectedBaudrate = 0;

        public static List<ProgramData> Programs = new List<ProgramData>();

        public class ProgramData
        {
            public string Title { get; set; } = "";
            public int Columns { get; set; } = 0;
            public int Rows { get; set; } = 0;
        }
    }
}
