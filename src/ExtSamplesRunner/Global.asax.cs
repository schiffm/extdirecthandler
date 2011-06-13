﻿using System;
using System.Web;
using ExtDirectHandler;
using ExtDirectHandler.Configuration;

namespace ExtSamplesRunner
{
	public class Global : HttpApplication
	{
		protected void Application_Start(object sender, EventArgs e)
		{
			DirectHttpHandler.SetMetadata(new ReflectionConfigurator()
			                                     	.RegisterType<TestAction>()
			                                     	.RegisterType<Profile>()
			                                     	.BuildMetadata());
		}

		protected void Session_Start(object sender, EventArgs e) {}

		protected void Application_BeginRequest(object sender, EventArgs e) {}

		protected void Application_AuthenticateRequest(object sender, EventArgs e) {}

		protected void Application_Error(object sender, EventArgs e) {}

		protected void Session_End(object sender, EventArgs e) {}

		protected void Application_End(object sender, EventArgs e) {}
	}
}