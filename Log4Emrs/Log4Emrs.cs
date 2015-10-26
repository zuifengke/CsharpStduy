using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;
namespace Log4Emrs
{
    /// <summary>
    /// Log4Emr时间日志记录类 作者：lf 时间：2013-09-18
    /// </summary>
    public class Log4Emr
    {
        /// <summary>
        /// Log格式
        /// </summary>
        private static readonly string Log_Content_Fomatter = "{0,-15}\t{1,-30}\t{2,-40}\t{3}\r\n";
        private static DateTime m_dtPriviousTime = DateTime.MaxValue;

        /// <summary>
        /// 前缀
        /// </summary>
        private static string _m_strPrefix = string.Empty;
        private static string m_strPrefix
        {
            get
            {
                return _m_strPrefix;
            }
            set
            {
                _m_strPrefix = value;
            }
        }

        /// <summary>
        /// 序号
        /// </summary>
        private static Int32 _m_nSerialNo = 0;
        private static Int32 m_nSerialNo
        {
            get
            {
                return _m_nSerialNo;
            }
            set
            {
                _m_nSerialNo = value;
            }
        }

        /// <summary>
        /// 流编写器
        /// </summary>
        private static StreamWriter _m_LogWriter;
        private static StreamWriter m_LogWriter
        {
            get
            {
                if (_m_LogWriter == null)
                {
                    string strFileName = ConfigurationSettings.AppSettings["FileName"];
                    if (!string.IsNullOrEmpty(strFileName))
                    {
                        _m_LogWriter = new StreamWriter(strFileName);
                    }
                    else
                    {
                        _m_LogWriter = new StreamWriter("Log.txt");
                    }
                }
                return _m_LogWriter;
            }

        }

        /// <summary>
        /// 设置前缀符号
        /// </summary>
        /// <param name="strPrefix">前缀</param>
        public static void SetPrefix(string strPrefix)
        {
            m_strPrefix = strPrefix;
        }


        /// <summary>
        /// 记录时间Log信息
        /// </summary>
        /// <param name="strLogTopic">日志标题</param>
        public static void LogInfo(string strLogTopic)
        {
            m_nSerialNo++;//序号+1
            DateTime dtStart = DateTime.Now;//取当前时间
            TimeSpan tsDuration = dtStart - m_dtPriviousTime;//时间间隔
            m_dtPriviousTime = dtStart;

            string strDuration = tsDuration.TotalMilliseconds > 0 ?
                string.Format("{0}ms", tsDuration.TotalMilliseconds) : string.Empty; //时间间隔

            string strSerialNo = string.Empty;//序号，如果有前缀，则加上
            if (!string.IsNullOrEmpty(m_strPrefix))
            {
                strSerialNo = m_strPrefix + "_" + m_nSerialNo.ToString();
            }
            else
            {
                strSerialNo = m_nSerialNo.ToString();
            }

            //写日志内容
            m_LogWriter.WriteLine(string.Format(Log_Content_Fomatter,
                strSerialNo,
                dtStart.ToString("yyyy/MM/dd HH:mm:ss.fff"),
                strLogTopic,
                strDuration));
        }


        /// <summary>
        /// 初始化-序号、前缀
        /// </summary>
        public static void Restart()
        {
            m_nSerialNo = 0;
            m_strPrefix = string.Empty;
        }

        /// <summary>
        /// 初始化-序号，设置-前缀
        /// </summary>
        /// <param name="strPrefix"></param>
        public static void Restart(string strPrefix)
        {
            m_nSerialNo = 0;
            m_strPrefix = strPrefix;
        }

        /// <summary>
        /// 清理缓冲区，并使所有缓冲数据写入文件流
        /// </summary>
        public static void Stop()
        {
            m_LogWriter.Flush();
        }

    }
}
