using System;
using ca.uhn.hl7v2.model;
namespace ca.uhn.hl7v2.model.v231.datatype
{
	///<summary>
	///<p>Represents the HL7 FT (formatted text data) datatype.  A FT contains a single String value.
	///<summary>
	[Serializable]
	public class FT : AbstractPrimitive  
	{

		///<summary>
		///Constructs an uninitialized FT.
		///<param name="message">The Message to which this Type belongs</param>
		///<summary>
		public FT(Message message) : base(message)
		{
		}

		///<summary>
		///  @return "2.3.1"
		///</summary>
		public string getVersion() 
		{
			return "2.3.1";
		}
	}
}