using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingProjectWF
{
    public static class GetData
    {
        //Hàm lấy chuỗi data dạng JSON từ API
        public static string GetDataFromApi(string apiUrl)
        {
            if (apiUrl == "")
            {
                return string.Empty;
            }
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    //  JObject json = JObject.Parse(content);
                    //   return json;
                    return content;
                }
                MessageBox.Show("Error in GetDataFromApi function.\n Status:" + response.StatusCode, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                if (Form1.flag == false)
                {
                    Form1.flag = true;
                    var dlr = MessageBox.Show("Vui lòng kiểm tra lại kết nối mạng", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dlr == DialogResult.OK)
                        Form1.flag = false;
                }
            }

            return string.Empty;
        }
    }
}
