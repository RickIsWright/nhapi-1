using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the NMQ_N01_CLOCK_AND_STATISTICS Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: NCK (System clock) <b>optional </b><br>
 * 1: NST (Application control level statistics) <b>optional </b><br>
 * 2: NSC (Application status change) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class NMQ_N01_CLOCK_AND_STATISTICS : AbstractGroup 
	{

		/** 
		 * Creates a new NMQ_N01_CLOCK_AND_STATISTICS Group.
		 */
		public NMQ_N01_CLOCK_AND_STATISTICS(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(NCK), false, false);
				this.add(typeof(NST), false, false);
				this.add(typeof(NSC), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating NMQ_N01_CLOCK_AND_STATISTICS - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns NCK (System clock) - creates it if necessary
		 */
		public NCK NCK 
		{ 
			get
			{
				NCK ret = null;
				try 
				{
					ret = (NCK)this.get_Renamed("NCK");
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
		 * Returns NST (Application control level statistics) - creates it if necessary
		 */
		public NST NST 
		{ 
			get
			{
				NST ret = null;
				try 
				{
					ret = (NST)this.get_Renamed("NST");
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
		 * Returns NSC (Application status change) - creates it if necessary
		 */
		public NSC NSC 
		{ 
			get
			{
				NSC ret = null;
				try 
				{
					ret = (NSC)this.get_Renamed("NSC");
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
