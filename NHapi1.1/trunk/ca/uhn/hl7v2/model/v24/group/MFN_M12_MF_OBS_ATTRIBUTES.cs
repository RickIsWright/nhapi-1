using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M12_MF_OBS_ATTRIBUTES Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFE (Master File Entry) <b></b><br>
 * 1: OM1 (General Segment) <b></b><br>
 * 2: OM7 (Additional Basic Attributes) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class MFN_M12_MF_OBS_ATTRIBUTES : AbstractGroup 
	{

		/** 
		 * Creates a new MFN_M12_MF_OBS_ATTRIBUTES Group.
		 */
		public MFN_M12_MF_OBS_ATTRIBUTES(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(MFE), true, false);
				this.add(typeof(OM1), true, false);
				this.add(typeof(OM7), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M12_MF_OBS_ATTRIBUTES - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns MFE (Master File Entry) - creates it if necessary
		 */
		public MFE MFE 
		{ 
			get
			{
				MFE ret = null;
				try 
				{
					ret = (MFE)this.get_Renamed("MFE");
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
		 * Returns OM1 (General Segment) - creates it if necessary
		 */
		public OM1 OM1 
		{ 
			get
			{
				OM1 ret = null;
				try 
				{
					ret = (OM1)this.get_Renamed("OM1");
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
		 * Returns OM7 (Additional Basic Attributes) - creates it if necessary
		 */
		public OM7 OM7 
		{ 
			get
			{
				OM7 ret = null;
				try 
				{
					ret = (OM7)this.get_Renamed("OM7");
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
