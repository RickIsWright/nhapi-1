using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v22.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the NMD_N01_CLOCK_AND_STATS_WITH_NOTES Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: NMD_N01_CLOCK (a Group object) <b>optional </b><br>
 * 1: NMD_N01_APP_STATS (a Group object) <b>optional </b><br>
 * 2: NMD_N01_APP_STATUS (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v22.group
{
[Serializable]
public class NMD_N01_CLOCK_AND_STATS_WITH_NOTES : AbstractGroup {

	/** 
	 * Creates a new NMD_N01_CLOCK_AND_STATS_WITH_NOTES Group.
	 */
	public NMD_N01_CLOCK_AND_STATS_WITH_NOTES(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(NMD_N01_CLOCK), false, false);
	      this.add(typeof(NMD_N01_APP_STATS), false, false);
	      this.add(typeof(NMD_N01_APP_STATUS), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating NMD_N01_CLOCK_AND_STATS_WITH_NOTES - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns NMD_N01_CLOCK (a Group object) - creates it if necessary
	 */
	public NMD_N01_CLOCK CLOCK { 
get{
	   NMD_N01_CLOCK ret = null;
	   try {
	      ret = (NMD_N01_CLOCK)this.get_Renamed("CLOCK");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns NMD_N01_APP_STATS (a Group object) - creates it if necessary
	 */
	public NMD_N01_APP_STATS APP_STATS { 
get{
	   NMD_N01_APP_STATS ret = null;
	   try {
	      ret = (NMD_N01_APP_STATS)this.get_Renamed("APP_STATS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns NMD_N01_APP_STATUS (a Group object) - creates it if necessary
	 */
	public NMD_N01_APP_STATUS APP_STATUS { 
get{
	   NMD_N01_APP_STATUS ret = null;
	   try {
	      ret = (NMD_N01_APP_STATUS)this.get_Renamed("APP_STATUS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
