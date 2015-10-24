using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace CshorpStudy
{
    public class WininetAPI
    {
        //判断计算机是否能够连接到Internet的API 
        //wininet.dll是Windows应用程序网络相关模块。该文件隶属于%\WINDOWS\SYSTEM32目录下动态库连接文件。
        //该文件不可缺失，属于关键链接库。当文件丢失或者损坏时，届时将无法完成Explorer进程（即桌面以及基于该进程的IE浏览器等，可使用不基于IE浏览器进行访问网络）
        [DllImport("wininet.dll")]
        public extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        //创建一个调用API函数（封装为C#方式）.
        /// <summary>
        /// 查看网络是否连接到公网
        /// </summary>
        /// <returns>返回Ture：可以连接到Internet，False则连接不上</returns>
        public static bool IsConnectedToInternet()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }
    }
}
