using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System.Runtime.InteropServices;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using System.Net.Cache;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;
using System.Drawing.Imaging;

namespace TradingProjectWF
{
    public partial class Form1 : Form
    {
        //private DateTime _time;
        private static int count = 11;
        private static string prevString;
        private static string currentString;
        public static bool flag = false;
        public static bool flagStart = false;
        private static string batDauStr = "Bắt đầu";
        private static string dungLaiStr = "Dừng lại";
        private static string fileNameDefault = "Export_Excel.xlsx";
        private static string textFileName = "temp.txt";

        private static string apiUrlGetData = "https://bddatafeed.vps.com.vn/getpschartintraday/VN30F1M";
        #region message define
        private static string successMessageCapNhat = "Cập nhật thành công";
        private static string errorMessageFileDangSuDung = "File excel đang được sử dụng, không thể tải lên dữ liệu";

        private static string messageChonDuongDan = "Vui lòng chọn đường dẫn thư mục";
        private static string messageBatDauClick = "Vui lòng nhấn bắt đầu";
        #endregion message define

        public Form1()
        {
            InitializeComponent();
            setDefaultFrom();
        }

        private void setDefaultFrom()
        {
            string urlFileExcel = GetUrlDefault();
            if (string.IsNullOrEmpty(urlFileExcel))
            {
                SetMessageChonDuongDan();
                setStyleDisplayForStartButton();
            }
            else
            {
                tbThuMuc.Text = urlFileExcel;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }   
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Load trang web, nạp html vào document
            //Uri url = new Uri("https://bddatafeed.vps.com.vn/getpschartintraday/VN30F1M");
            //if (count != 0) return;
           
        }

        private void SaveUrlDefault(string url)
        {
            try
            {
                if (!File.Exists(textFileName))
                {
                    FileStream objFileStrm = File.Create(textFileName);
                    objFileStrm.Close();
                }
                StreamWriter f = new StreamWriter(textFileName);
                f.WriteLine(url);
                f.Close();
            }
            catch (Exception)
            {
            }
            
        }
        private string GetUrlDefault()
        {
            if (File.Exists(textFileName))
            {
                StreamReader f = new StreamReader(textFileName);
                string result = f.ReadLine();
                f.Close();
                return result;
            }
            return string.Empty;
        }

        private void exportDataExcel()
        {
            if (string.IsNullOrEmpty(tbThuMuc.Text) && !flagStart)
            {
                SetMessageChonDuongDan();
                return;
            }
            else if (!string.IsNullOrEmpty(tbThuMuc.Text) && !flagStart)
            {
                lbThongBao.Text = messageBatDauClick;
                lbThongBao.ForeColor = Color.Red;
                return;
            }
            flagStart = true;

            var items = new List<Data>();
            var stringtest = GetData.GetDataFromApi(apiUrlGetData);
            if (stringtest != String.Empty)
            {
                items = JsonConvert.DeserializeObject<List<Data>>(stringtest).OrderByDescending(p => p.time).ToList();

                currentString = items.ToString();
            }
            string result = string.Empty;
            if (currentString != prevString)
            {
                var byteArray = Excel.CreateExcelFile(items);
                result = SaveByteArrayAsFile(tbThuMuc.Text, byteArray, fileNameDefault);

                //message error
                if (string.IsNullOrEmpty(result))
                {
                    lbThongBao.Text = successMessageCapNhat + " lúc " + DateTime.Now;
                    lbThongBao.ForeColor = Color.Green;
                    prevString = currentString;
                    return;
                }

                lbThongBao.Text = result;
                if (result != String.Empty)
                {
                    lbThongBao.ForeColor = Color.Red;
                }
            }
        }

        private void SetMessageChonDuongDan()
        {
            lbThongBao.Text = messageChonDuongDan;
            lbThongBao.ForeColor = Color.Red;
        }
        public static void SaveStreamAsFile(string filePath, Stream inputStream, string fileName)
        {
            DirectoryInfo info = new DirectoryInfo(filePath);
            if (!info.Exists)
            {
                info.Create();
            }

            string path = Path.Combine(filePath, fileName);
            using (FileStream outputFileStream = new FileStream(path, FileMode.Create))
            {
                inputStream.CopyTo(outputFileStream);
            }
        }

        public static string SaveByteArrayAsFile(string filePath, byte[] inputStream, string fileName)
        {
            // file name with .xlsx extension
            var fullPath = filePath + "/" + fileName;

            //if (File.Exists(fullPath))
            //    File.Delete(fullPath);

            if (!File.Exists(fullPath))
            {
                FileStream objFileStrm = File.Create(fullPath);
                objFileStrm.Close();
            }

            Stream s = null;
            try
            {
                s = File.Open(fullPath, FileMode.Open, FileAccess.Read, FileShare.None);

                s.Close();
            }
            catch (Exception _IO)
            {
                return errorMessageFileDangSuDung;
            }
            if (s != null) s.Close();

            // Write content to excel file  
            File.WriteAllBytes(fullPath, inputStream);
            return string.Empty;
            //Close Excel package 
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbTrangThai_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                lbThongBao.Text = string.Empty;

                tbThuMuc.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
            prevString = string.Empty;
            setStyleDisplayForStartButton();
            SaveUrlDefault(tbThuMuc.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetCountValue();
            if (button2.Text != null && button2.Text.Equals(dungLaiStr))
            {
                flagStart = false;
                button2.Text = batDauStr;
            }
            else
            {
                flagStart =  true;
                button2.Text = dungLaiStr;
            }    
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (flagStart && count != 0)
            {
                count--;
                lbBatDau.Text = "Chương trình sẽ chạy trong " + count.ToString() + " ...";
            }
            else if (flagStart && count == 0)
            {
                //timer1.Start();
                exportDataExcel();
                resetCountValue();
            }
            else if (!flagStart)
            {
                timer1.Stop();
            }
        }

        private bool isExistsPathExcel()
        {
            return !string.IsNullOrEmpty(tbThuMuc.Text);
        }
        private void resetCountValue()
        {
            count = 11;
        }
        private void setStyleDisplayForStartButton()
        {
            if (!isExistsPathExcel())
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }
    }
}
