using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using YemekSepetiFiyat.Class;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;

using System.Reflection;
using System.IO;
using System.Web.UI;
using System.Net.NetworkInformation;
using System.Net;
using System.Configuration;
using System.Drawing.Drawing2D;

namespace YemekSepetiFiyat.Class
{
    public class MyThread : SuspendableThread, IDisposable
    {
        public event EventHandler Disposed;

        public void Dispose()
        {
            if (this.Disposed != null)
                this.Disposed(this, EventArgs.Empty);
        }
        public int r = 0;


        protected override void OnDoWork()
        {
            try
            {
                while (false == HasTerminateRequest())
                {
                    Boolean awokenByTerminate = SuspendIfNeeded();
                    if (awokenByTerminate)
                    {
                        return;
                    }

                    // TODO: replace the following to lines
                    Debug.WriteLine("doing some work...");
                    Thread.Sleep(450);
                }
            }
            finally
            {
                // TODO: Replace the following line with thread
                // exit processing.
                Debug.WriteLine("Exiting ThreadEntry()...");
            }
        }
    }
    public abstract class SuspendableThread
    {
        #region Data
        public MyMessageBox cs = new MyMessageBox();
        private ManualResetEvent suspendChangedEvent = new ManualResetEvent(false);
        private ManualResetEvent terminateEvent = new ManualResetEvent(false);
        private long suspended;
        private Thread thread;
        private System.Threading.ThreadState failsafeThreadState = System.Threading.ThreadState.Unstarted;
        #endregion Data
        public void showMessageForStartUp()
        {

            
                string result = MyMessageBox.ShowBox("Lütfen Bekleyiniz ...", "Lütfen bekleyiniz");
          


        }
        public SuspendableThread()
        {
        }

        private void ThreadEntry()
        {
            failsafeThreadState = System.Threading.ThreadState.Stopped;
            OnDoWork();
        }

        protected abstract void OnDoWork();

        #region Protected methods
        protected Boolean SuspendIfNeeded()
        {
            Boolean suspendEventChanged = suspendChangedEvent.WaitOne(0, true);
            if (suspendEventChanged)
            {
                Boolean needToSuspend = Interlocked.Read(ref suspended) != 0;
                suspendChangedEvent.Reset();
                if (needToSuspend)
                {
                    /// Suspending...
                    if (1 == WaitHandle.WaitAny(new WaitHandle[] { suspendChangedEvent, terminateEvent }))
                    {
                        return true;
                    }
                    /// ...Waking
                }
            }
            return false;
        }

        protected bool HasTerminateRequest()
        {
            return terminateEvent.WaitOne(0, true);
        }
        #endregion Protected methods

        public void Start()
        {
            thread = new Thread(new ThreadStart(showMessageForStartUp));

            // make sure this thread won't be automaticaly
            // terminated by the runtime when the
            // application exits
            thread.IsBackground = false;

            thread.Start();
        }

        public void Join()
        {
            if (thread != null)
            {
                thread.Join();
            }
        }

        public Boolean Join(Int32 milliseconds)
        {
            if (thread != null)
            {
                return thread.Join(milliseconds);
            }
            return true;
        }

        /// <remarks>Not supported in .NET Compact Framework</remarks>
        public Boolean Join(TimeSpan timeSpan)
        {
            if (thread != null)
            {
                return thread.Join(timeSpan);
            }
            return true;
        }

        public void Terminate()
        {
            terminateEvent.Set();
        }

        public void TerminateAndWait()
        {
            terminateEvent.Set();
            thread.Join();
        }

        public void Suspend()
        {
            while (1 != Interlocked.Exchange(ref suspended, 1))
            {
            }
            suspendChangedEvent.Set();
       
         
        }

        public void Resume()
        {
            while (0 != Interlocked.Exchange(ref suspended, 0))
            {
            }
            suspendChangedEvent.Set();

        }

        public System.Threading.ThreadState ThreadState
        {
            get
            {
                if (null != thread)
                {
                    return thread.ThreadState;
                }
                return failsafeThreadState;
            }
        }
    }
}
