using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v23.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v23.segment
{

	/**
	 * <p>Represents an HL7 QCK message segment. 
	 * This segment has the following fields:</p><p>
	 * </p><p>The get...() methods return data from individual fields.  These methods 
	 * do not throw exceptions and may therefore have to handle exceptions internally.  
	 * If an exception is handled internally, it is logged and null is returned.  
	 * This is not expected to happen - if it does happen this indicates not so much 
	 * an exceptional circumstance as a bug in the code for this class.</p>    
	 */
	[Serializable]
	public class QCK : AbstractSegment  
	{

		/**
		 * Creates a QCK () segment object that belongs to the given 
		 * message.  
		 */
		public QCK(Group parent, ModelClassFactory factory) : base(parent,factory) 
		{
			Message message = Message;
		}


	}}