using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PRR_PC5_PROBLEM_PATHWAY Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PTH (Pathway) <b></b><br>
 * 1: VAR (Variance) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class PRR_PC5_PROBLEM_PATHWAY : AbstractGroup 
	{

		/** 
		 * Creates a new PRR_PC5_PROBLEM_PATHWAY Group.
		 */
		public PRR_PC5_PROBLEM_PATHWAY(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(PTH), true, false);
				this.add(typeof(VAR), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PRR_PC5_PROBLEM_PATHWAY - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns PTH (Pathway) - creates it if necessary
		 */
		public PTH PTH 
		{ 
			get
			{
				PTH ret = null;
				try 
				{
					ret = (PTH)this.get_Renamed("PTH");
				} 
				catch(HL7Exception e) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
		}

		/**
		 * Returns  first repetition of VAR (Variance) - creates it if necessary
		 */
		public VAR getVAR() 
		{
			VAR ret = null;
			try 
			{
				ret = (VAR)this.get_Renamed("VAR");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of VAR
		 * (Variance) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public VAR getVAR(int rep) 
		{ 
			return (VAR)this.get_Renamed("VAR", rep);
		}

		/** 
		 * Returns the number of existing repetitions of VAR 
		 */ 
		public int VARReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("VAR").Length; 
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

	}
}
