using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PPT_PCL_GOAL_OBSERVATION Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OBX (Observation segment) <b></b><br>
 * 1: NTE (Notes and comments segment) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class PPT_PCL_GOAL_OBSERVATION : AbstractGroup {

	/** 
	 * Creates a new PPT_PCL_GOAL_OBSERVATION Group.
	 */
	public PPT_PCL_GOAL_OBSERVATION(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("OBX", "2.3"), true, false);
	      this.add(factory.getSegmentClass("NTE", "2.3"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PPT_PCL_GOAL_OBSERVATION - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns OBX (Observation segment) - creates it if necessary
	 */
	public OBX OBX { 
get{
	   OBX ret = null;
	   try {
	      ret = (OBX)this.get_Renamed("OBX");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of NTE (Notes and comments segment) - creates it if necessary
	 */
	public NTE  getNTE() { 
	   NTE ret = null;
	   try {
	      ret = (NTE)this.get_Renamed("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NTE
	 * (Notes and comments segment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NTE getNTE(int rep) { 
	   return (NTE)this.get_Renamed("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("NTE").Length; 
	    }
 catch (HL7Exception e) 
{ 
	        String message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}