using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PEX_P07_EXPERIENCE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PES (Product Experience Sender) <b></b><br>
 * 1: PEX_P07_PEX_OBSERVATION (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class PEX_P07_EXPERIENCE : AbstractGroup {

	/** 
	 * Creates a new PEX_P07_EXPERIENCE Group.
	 */
	public PEX_P07_EXPERIENCE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(PES), true, false);
	      this.add(typeof(PEX_P07_PEX_OBSERVATION), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PEX_P07_EXPERIENCE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns PES (Product Experience Sender) - creates it if necessary
	 */
	public PES PES { 
get{
	   PES ret = null;
	   try {
	      ret = (PES)this.get_Renamed("PES");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of PEX_P07_PEX_OBSERVATION (a Group object) - creates it if necessary
	 */
	public PEX_P07_PEX_OBSERVATION getPEX_OBSERVATION() {
	   PEX_P07_PEX_OBSERVATION ret = null;
	   try {
	      ret = (PEX_P07_PEX_OBSERVATION)this.get_Renamed("PEX_OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PEX_P07_PEX_OBSERVATION
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PEX_P07_PEX_OBSERVATION getPEX_OBSERVATION(int rep) { 
	   return (PEX_P07_PEX_OBSERVATION)this.get_Renamed("PEX_OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PEX_P07_PEX_OBSERVATION 
	 */ 
	public int PEX_OBSERVATIONReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("PEX_OBSERVATION").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}
