using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Collections;
using System.Collections;        
using Castle.ActiveRecord.Framework.Config;
using Castle.ActiveRecord;
using Model;
using Castle.ActiveRecord.Framework;
namespace Blog
{
    public class Global : System.Web.HttpApplication
    {

        public Global()
        {
            BeginRequest += new EventHandler(OnBeginRequest);
            EndRequest += new EventHandler(OnEndRequest); 
        
        }

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup

           
            IConfigurationSource source = ActiveRecordSectionHandler.Instance;            
            ActiveRecordStarter.Initialize(source,  typeof(Post));        

        }

         public void OnBeginRequest(object sender, EventArgs e)       
         {          HttpContext.Current.Items.Add("ar.sessionscope", new SessionScope());          
         } 

        public void OnEndRequest(object sender, EventArgs e) { 
            try { 
                SessionScope scope = HttpContext.Current.Items["ar.sessionscope"] as SessionScope; 
                if (scope != null) { scope.Dispose(); } } 
            catch (Exception ex) 
            { HttpContext.Current.Trace.Warn("Error", "EndRequest: " + ex.Message, ex); } 
        
        }



        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

    }
}
