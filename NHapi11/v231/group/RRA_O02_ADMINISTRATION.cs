using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RRA_O02_ADMINISTRATION Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RXA (RXA - pharmacy/treatment administration segment) <b>repeating</b><br>
 * 1: RXR (RXR - pharmacy/treatment route segment) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class RRA_O02_ADMINISTRATION : AbstractGroup 
	{

		/** 
		 * Creates a new RRA_O02_ADMINISTRATION Group.
		 */
		public RRA_O02_ADMINISTRATION(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(RXA), true, true);
				this.add(typeof(RXR), true, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRA_O02_ADMINISTRATION - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns  first repetition of RXA (RXA - pharmacy/treatment administration segment) - creates it if necessary
		 */
		public RXA getRXA() 
		{
			RXA ret = null;
			try 
			{
				ret = (RXA)this.get_Renamed("RXA");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of RXA
		 * (RXA - pharmacy/treatment administration segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RXA getRXA(int rep) 
		{ 
			return (RXA)this.get_Renamed("RXA", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RXA 
		 */ 
		public int RXAReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("RXA").Length; 
				} 
				catch (HL7Exception e) 
				{ 
					string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
					HapiLogFactory.getHapiLog(GetType()).error(message, e); 
					throw new System.Exception(message);
				} 
				return reps; 
			}
		} 

		/**
		 * Returns RXR (RXR - pharmacy/treatment route segment) - creates it if necessary
		 */
		public RXR RXR 
		{ 
			get
			{
				RXR ret = null;
				try 
				{
					ret = (RXR)this.get_Renamed("RXR");
				} 
				catch(HL7Exception e) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
		}

	}
}
