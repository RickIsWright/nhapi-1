/*
* HapiLogFactory.java
* 
* Created on May 7, 2003 at 2:19:17 PM
*/
using System;
namespace ca.uhn.log
{
	
	/// <summary> <p>Factory for creating {@link HapiLog} instances. It is factory
	/// that delegates the discovery process to the <code> LogFactory </code>
	/// class and wraps the discovered <code> Log </code> with a new instance of
	/// the <code>HapiLog</code> class.
	/// 
	/// </summary>
	/// <author>  <a href="mailto:alexei.guevara@uhn.on.ca">Alexei Guevara</a>
	/// </author>
	/// <version>  $Revision: 1.1.1.1 $ updated on $Date: 2006/05/16 19:49:23 $ by $Author: whitedog12 $
	/// </version>
	public sealed class HapiLogFactory
	{
		
		/// <summary> Do not allow instantiation.</summary>
		private HapiLogFactory()
		{
		}
		
		/// <summary> Convenience method to return a named HAPI logger, without the application
		/// having to care about factories.
		/// 
		/// </summary>
		/// <param name="clazz">Class for which a log name will be derived
		/// 
		/// </param>
		/// <exception cref="LogConfigurationException">if a suitable <code>Log</code>
		/// instance cannot be returned
		/// </exception>
		public static HapiLog getHapiLog(System.Type clazz)
		{
			HapiLog retVal = null;
			
			Log log = LogFactory.getLog(clazz);
			retVal = new HapiLogImpl(log);
			
			return retVal;
		}
		
		/// <summary> Convenience method to return a named HAPI logger, without the application
		/// having to care about factories.
		/// 
		/// </summary>
		/// <param name="name">Logical name of the <code>Log</code> instance to be
		/// returned (the meaning of this name is only known to the underlying
		/// logging implementation that is being wrapped)
		/// 
		/// </param>
		/// <exception cref="LogConfigurationException">if a suitable <code>Log</code>
		/// instance cannot be returned
		/// </exception>
		public static HapiLog getHapiLog(System.String name)
		{
			HapiLog retVal = null;
			
			Log log = LogFactory.getLog(name);
			retVal = new HapiLogImpl(log);
			
			return retVal;
		}
	}
}