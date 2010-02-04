<%@ Application Language="C#"   %>

<script runat="server">
    string result;
    void Application_Start(object sender, EventArgs e) 
    {
        
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        
    }
    
    void Application_BeginRequest(object sender, EventArgs e) 
    {
        result = String.Empty;
        result += "BeginRequest fired <br />";

    }
    
    void Application_AuthenticateRequest(object sender, EventArgs e) 
    {
        
        result += "AuthenticateRequest fired <br />";

    }
    void Application_PostAuthenticateRequest(object sender, EventArgs e) 
    {
        
        result += "PostAuthenticateRequest fired <br />";

    }
    void Application_AuthorizeRequest(object sender, EventArgs e) 
    {
        
        result += "AuthorizeRequest fired <br />";

    }
    void Application_PostAuthorizeRequest(object sender, EventArgs e) 
    {
        
        result += "PostAuthorizeRequest fired <br />";

    }
    void Application_ResolveRequestCache(object sender, EventArgs e) 
    {
        
        result += "ResolveRequestCache fired <br />";

    }
    void Application_PostResolveRequestCache(object sender, EventArgs e) 
    {
        
        result += "PostResolveRequestCache fired <br />";

    }
    void Application_PostMapRequestHandler(object sender, EventArgs e) 
    {
        
        result += "PostMapRequestHandler fired <br />";

    }
    void Application_AcquireRequestState(object sender, EventArgs e)
    {
        result += "AcquireRequestState fired <br />";
    }
    
    void Application_PostAcquireRequestState(object sender, EventArgs e) 
    {
        
        result += "PostAcquireRequestState fired <br />";

    }
    void Application_PreRequestHandlerExecute(object sender, EventArgs e) 
    {
        
        result += "PreRequestHandlerExecute fired <br />";

    }
    void Application_PostRequestHandlerExecute(object sender, EventArgs e) 
    {
        
        result += "PostRequestHandlerExecute fired <br />";

    }
    void Application_ReleaseRequestState(object sender, EventArgs e) 
    {
        
        result += "ReleaseRequestState fired <br />";

    }
    void Application_PostReleaseRequestState(object sender, EventArgs e) 
    {
        
        result += "PostReleaseRequestState fired <br />";

    }
    void Application_UpdateRequestCache(object sender, EventArgs e) 
    {
        
        result += "UpdateRequestCache fired <br />";

    }
    void Application_PostUpdateRequestCache(object sender, EventArgs e) 
    {
        
        result += "PostUpdateRequestCache fired <br />";

    }
    
    
    void Application_EndRequest(object sender, EventArgs e) 
    {
         result += "EndRequest fired <br />";
         this.Response.Write(result);
    }
    
    
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs
      
    }
    

    void Session_Start(object sender, EventArgs e) 
    {
       result += "Session_Start fired <br />";

    }

    void Session_End(object sender, EventArgs e) 
    {
         result += "Session_End fired <br />";
    }
       
</script>
