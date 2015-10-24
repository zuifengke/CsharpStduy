using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CshorpStudy.EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();

            EventReader1 reader1 = new EventReader1(publisher);

            EventReader2 reader2 = new EventReader2(publisher);

            publisher.DoSomthing();

            Console.WriteLine("This program already finished!");

            Console.ReadLine();

        }
      
         ///<summary>

    /// EventPublisher : 事件的发布者。

    ///</summary>

    public class EventPublisher

    {

       // 第一步是申明委托

       public delegate int sampleEventDelegate(string messageInfo);

       // 第二步是申明与上述委托相关的事件

       public event sampleEventDelegate sampleEvent;

       public EventPublisher()

       {

       }

       public void DoSomthing()

       {

           /* ... */

           // 激发事件

           if(this.sampleEvent != null)

           {

              this.sampleEvent("hello world!");

           }

           /* ... */

       }

    }

    ///<summary>

    /// EventReader1 : 事件的订阅者1。

    ///</summary>

    public class EventReader1

    {

       public EventReader1(EventPublisher publisher)

       {

           publisher.sampleEvent += 

              new EventPublisher.sampleEventDelegate(ResponseEvent);

       }

       private int ResponseEvent(string msg)

       {

           Console.WriteLine(msg + " --- This is from reader1");

           return 0;

       }

    }

    ///<summary>

    /// EventReader2 : 事件的订阅者2。

    ///</summary>

    public class EventReader2

    {

       public EventReader2(EventPublisher publisher)

       {

           publisher.sampleEvent += 

              new EventPublisher.sampleEventDelegate(ResponseEvent);

publisher.sampleEvent += 

              new EventPublisher.sampleEventDelegate(ResponseEvent);

       }

       private int ResponseEvent(string msg)

       {

           Console.WriteLine(msg + " --- This is from reader2");

           Console.WriteLine("Please:down enter key!");

           Console.ReadLine();

           Console.WriteLine("ok");

           return 0;

       }

    }

}

    
}
