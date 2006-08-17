using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v23.segment;

using NHapi.Base.model;
/**
 * <p>Represents the MFN_M06_MF_PHASE_SCHED_DETAIL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: CM1 (Clinical Study Phase Master) <b></b><br>
 * 1: CM2 (Clinical Study Schedule Master) <b>optional repeating</b><br>
 */
namespace NHapi.Base.model.v23.group
{
[Serializable]
public class MFN_M06_MF_PHASE_SCHED_DETAIL : AbstractGroup {

	/** 
	 * Creates a new MFN_M06_MF_PHASE_SCHED_DETAIL Group.
	 */
	public MFN_M06_MF_PHASE_SCHED_DETAIL(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("CM1", "2.3"), true, false);
	      this.add(factory.getSegmentClass("CM2", "2.3"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M06_MF_PHASE_SCHED_DETAIL - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns CM1 (Clinical Study Phase Master) - creates it if necessary
	 */
	public CM1 CM1 { 
get{
	   CM1 ret = null;
	   try {
	      ret = (CM1)this.get_Renamed("CM1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of CM2 (Clinical Study Schedule Master) - creates it if necessary
	 */
	public CM2  getCM2() { 
	   CM2 ret = null;
	   try {
	      ret = (CM2)this.get_Renamed("CM2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of CM2
	 * (Clinical Study Schedule Master) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public CM2 getCM2(int rep) { 
	   return (CM2)this.get_Renamed("CM2", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CM2 
	 */ 
	public int CM2Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("CM2").Length; 
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