// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Excell = Microsoft.Office.Interop.Excel;

namespace Ball_Throw
{
    class Excel:FlyBall
    {       
        _Application excel = new Excell.Application();
        Workbook wb;
        Worksheet ws;

        public Excel()
        {

        }

        public Excel(double height, double speed_throw, double speed_wind, string n_th, string n_wind) : base(height, speed_throw, speed_wind, n_th, n_wind)
        {
            
        }
        
        public void Open(string path, int sheet)
        {           
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }

        public string ReadCell(int i, int j)
        {          
            if (ws.Cells[i, j].Value != null)
                return ws.Cells[i, j].Value.ToString();
            else return "";
        }

        public void Writecell(int i, int j, string c)
        {           
            ws.Cells[i, j].Value = c;
        }      

        public void Save()
        {
            wb.Save();
        }

        public void Close()
        {
            ws = null;
            wb.Close(false, false, false);
            excel.Quit();
            wb = null;
            excel = null;
            GC.Collect();
        }        
    }
}

