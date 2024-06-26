﻿using System;
namespace Dot_Net_Tutorial.Extensions
{
	public static class HttpContextExtension
	{
		public static int GetUserId(this HttpContext httpContext)
		{
			return httpContext.Items["UserId"] as int? ??
				throw new Exception("User ID not found in HttpContext.Items");
		}
	}
}

