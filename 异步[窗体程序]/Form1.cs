using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 异步_窗体程序_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //long num = 0;
            //while (true)
            //{
            //    num += new Random().Next(-100,100);
            //    //Thread.Sleep(100);
            //}

            //for (int i = 0; i < 1000; i++)
            //{
            //    new Thread(() => { Thread.Sleep(1000000); }).Start();
            //}
            //var num = Process.GetCurrentProcess().Threads.Count;

        }


        //1、同步方法
        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("【Debug】线程ID:" + Thread.CurrentThread.ManagedThreadId);

            var request = WebRequest.Create("https://github.com/");//https://msdn.microsoft.com/zh-cn/
            request.GetResponse();//发送请求    

            Debug.WriteLine("【Debug】线程ID:" + Thread.CurrentThread.ManagedThreadId);
            label1.Text = "执行完毕！";
        }

        //2、异步方法
        private void button2_Click(object sender, EventArgs e)
        {
            //1、APM 异步编程模型，Asynchronous Programming Model
            //C#1[基于IAsyncResult接口实现BeginXXX和EndXXX的方法]             
            //Debug.WriteLine("【Debug】主线程ID:" + Thread.CurrentThread.ManagedThreadId);

            //var request = WebRequest.Create("https://github.com/");
            //request.BeginGetResponse(new AsyncCallback(t =>
            //{
            //    var response = request.EndGetResponse(t);//执行完成后的回调 
            //    var stream = response.GetResponseStream();//获取返回数据流 

            //    using (StreamReader reader = new StreamReader(stream))
            //    {
            //        StringBuilder sb = new StringBuilder();
            //        while (!reader.EndOfStream)
            //        {
            //            var content = reader.ReadLine();
            //            sb.Append(content);
            //        }
            //        Debug.WriteLine("【Debug】" + sb.ToString().Trim().Substring(0, 100) + "...");//只取返回内容的前100个字符 
            //        Debug.WriteLine("【Debug】异步线程ID:" + Thread.CurrentThread.ManagedThreadId);
            //        label1.Invoke((Action)(() => { label1.Text = "执行完毕！"; }));//这里跨线程访问UI需要做处理
            //    }
            //}), null);

            //Debug.WriteLine("【Debug】主线程ID:" + Thread.CurrentThread.ManagedThreadId);


            //2、阻塞等待异步
            //var asyncResult = request.BeginGetResponse(null, null);
            //asyncResult.AsyncWaitHandle.WaitOne();
            ////while (!asyncResult.IsCompleted)
            ////{
            ////    Thread.Sleep(100);
            ////}

            //var stream2 = request.EndGetResponse(asyncResult).GetResponseStream();
            //using (StreamReader reader = new StreamReader(stream2))
            //{
            //    StringBuilder sb = new StringBuilder();
            //    while (!reader.EndOfStream)
            //    {
            //        var content = reader.ReadLine();
            //        sb.AppendLine(content);
            //    }
            //    Debug.WriteLine(sb.ToString().Trim().Substring(0, 100) + "...");//只取返回内容的前100个字符 
            //    Debug.WriteLine("线程ID:" + Thread.CurrentThread.ManagedThreadId);
            //    label1.Invoke((Action)(() => { label1.Text = ""; }));//这里跨线程访问UI需要做处理
            //}

            //3、通过委托
            MyAction();
        }

        public void MyAction()
        {
            string str1 = string.Empty, str2 = string.Empty, str3 = string.Empty;
            IAsyncResult asyncResult1 = null, asyncResult2 = null, asyncResult3 = null;
            asyncResult1 = func1().BeginInvoke("张三", t =>
            {
                str1 = func1().EndInvoke(t);
                Debug.WriteLine("【Debug】异步线程ID:" + Thread.CurrentThread.ManagedThreadId);
                asyncResult2 = func2().BeginInvoke("26", a =>
                {
                    str2 = func2().EndInvoke(a);
                    Debug.WriteLine("【Debug】异步线程ID:" + Thread.CurrentThread.ManagedThreadId);
                    asyncResult3 = func3().BeginInvoke("男", s =>
                    {
                        str3 = func3().EndInvoke(s);
                        Debug.WriteLine("【Debug】异步线程ID:" + Thread.CurrentThread.ManagedThreadId);
                    }, null);
                }, null);
            }, null);

            asyncResult1.AsyncWaitHandle.WaitOne();
            asyncResult2.AsyncWaitHandle.WaitOne();
            asyncResult3.AsyncWaitHandle.WaitOne();
            Debug.WriteLine(str1 + str2 + str3);
        }

        public Func<string, string> func1()
        {
            return new Func<string, string>(t =>
            {
                Thread.Sleep(2000);
                return "name:" + t;
            });
        }
        public Func<string, string> func2()
        {
            return new Func<string, string>(t =>
            {
                Thread.Sleep(2000);
                return "age:" + t;
            });
        }
        public Func<string, string> func3()
        {
            return new Func<string, string>(t =>
            {
                Thread.Sleep(2000);
                return "sex:" + t;
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //var _asyncWaitHandle = new AutoResetEvent(false);
            //_asyncWaitHandle.Set();
            //_asyncWaitHandle.WaitOne(); 

            Debug.WriteLine("【Debug】主线程ID:" + Thread.CurrentThread.ManagedThreadId);
            var aa = MyBeginXX(new AsyncCallback(t =>
            {
                var result = MyEndXX(t);
                Debug.WriteLine("【Debug】" + result.Trim().Substring(0, 100) + "...");
                Debug.WriteLine("【Debug】异步线程ID:" + Thread.CurrentThread.ManagedThreadId);
                label1.Invoke((Action)(() => { label1.Text = "执行完毕！"; }));//这里跨线程访问UI需要做处理
            }));

            var ab = (MyWebRequest)aa;

            var cc = aa.AsyncWaitHandle.WaitOne();
            Debug.WriteLine("【Debug】主线程ID:" + Thread.CurrentThread.ManagedThreadId);
        }

        public IAsyncResult MyBeginXX(AsyncCallback callback)
        {
            var asyncResult = new MyWebRequest(callback, null);
            var request = WebRequest.Create("https://github.com/");
            new Thread(() =>  //重新启用一个线程
            {
                using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream()))
                {
                    var str = sr.ReadToEnd();
                    asyncResult.SetComplete(str);//设置异步结果
                }

            }).Start();
            return asyncResult;//放回一个IAsyncResult
        }

        public string MyEndXX(IAsyncResult asyncResult)
        {
            MyWebRequest result = asyncResult as MyWebRequest;
            return result.Result;
        }
        public class MyWebRequest : IAsyncResult
        {
            //异步回调函数（委托）
            private AsyncCallback _asyncCallback;
            private AutoResetEvent _asyncWaitHandle;
            public MyWebRequest(AsyncCallback asyncCallback, object state)
            {
                _asyncCallback = asyncCallback;
                _asyncWaitHandle = new AutoResetEvent(false);
            }
            //设置结果
            public void SetComplete(string result)
            {
                Result = result;
                IsCompleted = true;
                _asyncWaitHandle.Set();
                if (_asyncCallback != null)
                {
                    _asyncCallback(this);
                }
            }
            //异步请求返回值
            public string Result { get; set; }
            //获取用户定义的对象，它限定或包含关于异步操作的信息。
            public object AsyncState
            {
                get { throw new NotImplementedException(); }
            }
            // 获取用于等待异步操作完成的 System.Threading.WaitHandle。
            public WaitHandle AsyncWaitHandle
            {
                //get { throw new NotImplementedException(); }

                get { return _asyncWaitHandle; }
            }
            //获取一个值，该值指示异步操作是否同步完成。
            public bool CompletedSynchronously
            {
                get { throw new NotImplementedException(); }
            }
            //获取一个值，该值指示异步操作是否已完成。
            public bool IsCompleted
            {
                get;
                private set;
            }
        }

        //EAP
        private void button3_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("【Debug】主线程ID:" + Thread.CurrentThread.ManagedThreadId);

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler((s1, s2) =>
            {
                Thread.Sleep(2000);
                Debug.WriteLine("【Debug】异步线程ID:" + Thread.CurrentThread.ManagedThreadId);
            });//注册事件来实现异步
            worker.RunWorkerAsync(this);
            Debug.WriteLine("【Debug】主线程ID:" + Thread.CurrentThread.ManagedThreadId);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //var task1 = Task<string>.Run(() =>
            //{
            //    Thread.Sleep(1500);
            //    Console.WriteLine("【Debug】task1 线程ID:" + Thread.CurrentThread.ManagedThreadId);
            //    return "张三";
            //});
            ////其他逻辑            
            //task1.Wait();
            //var value = task1.Result;//获取返回值
            //Console.WriteLine("【Debug】主 线程ID:" + Thread.CurrentThread.ManagedThreadId);

            ////如果嵌套100层？
            Console.WriteLine("【Debug】主 线程ID:" + Thread.CurrentThread.ManagedThreadId);
            string str1 = string.Empty, str2 = string.Empty, str3 = string.Empty;
            var task1 = Task.Run(() =>
            {
                Thread.Sleep(500);
                str1 = "姓名：张三,";
                Console.WriteLine("【Debug】task1 线程ID:" + Thread.CurrentThread.ManagedThreadId);
            });
            task1.Wait();
            var task2 = Task.Run(() =>
            {
                Thread.Sleep(500);
                str2 = "年龄：25,";
                Console.WriteLine("【Debug】task2 线程ID:" + Thread.CurrentThread.ManagedThreadId);
            }).ContinueWith(t =>
            {
                Thread.Sleep(500);
                str3 = "爱好：妹子";
                Console.WriteLine("【Debug】task3 线程ID:" + Thread.CurrentThread.ManagedThreadId);
            });
            task2.Wait(); 

            Debug.WriteLine(str1 + str2 + str3);
            Console.WriteLine("【Debug】主 线程ID:" + Thread.CurrentThread.ManagedThreadId);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
