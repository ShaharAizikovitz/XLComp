using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

using Excel = Microsoft.Office.Interop.Excel;


namespace ExcelReader
{
    public class Reader
    {
        private string path;
        private Excel.Application xlApp;
        private Excel.Workbook xlWorkBook;
        private ArrayList list;

        //ctor
        public Reader()
        {
            openXl();
        }

        public void openXl()
        {
            this.path = Directory.GetCurrentDirectory();
            this.path = "C:\\Users\\User\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\tst.xlsx";
            this.xlApp = new Excel.Application();
            this.xlWorkBook = xlApp.Workbooks.Open(this.path);

            Excel._Worksheet xlWorkSheet = xlWorkBook.Sheets[1] as Excel.Worksheet;
        }

        public void read()
        {
            foreach (Excel.Worksheet worksheet  in this.xlWorkBook.Sheets)
            {

            }
        }

        public void compare()
        {

        }

        public string write()
        {
            string result = "test";
            return result;
        }

        ~Reader()
        {
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //release com objects to fully kill excel process from running in the background
            //Marshal.ReleaseComObject(xlRange);
            //Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkBook.Close();
            Marshal.ReleaseComObject(xlWorkBook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

    }


}
