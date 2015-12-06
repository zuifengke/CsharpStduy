using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandAsyncAwait
{

    public interface ICallBackRegister
    {
        ICallBackRegister Register<T>(Action<T> callback);
        void Await(Task task);
    }

    public class CallbackRegister:ICallBackRegister
    {
        Action<object> _action; 
        public ICallBackRegister Register<T>(Action<T> callback)
        {
            _action = o => callback((T) o);
            return this;
        }

        public void Await(Task task)
        {
            task.ContinueWith((result)=>_action(result));
        }
    }
}
