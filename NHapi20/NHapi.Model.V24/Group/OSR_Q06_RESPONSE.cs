using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
///<summary>
///Represents the OSR_Q06_RESPONSE Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
/// * 0: OSR_Q06_PATIENT (a Group object) optional 
/// * 1: OSR_Q06_ORDER (a Group object) repeating
///</summary>
[Serializable]
public class OSR_Q06_RESPONSE : AbstractGroup {

	///<summary> 
	/// Creates a new OSR_Q06_RESPONSE Group.
	///</summary>
	public OSR_Q06_RESPONSE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(OSR_Q06_PATIENT), false, false);
	      this.add(typeof(OSR_Q06_ORDER), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OSR_Q06_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns OSR_Q06_PATIENT (a Group object) - creates it if necessary
	///</summary>
	public OSR_Q06_PATIENT PATIENT { 
get{
	   OSR_Q06_PATIENT ret = null;
	   try {
	      ret = (OSR_Q06_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of OSR_Q06_ORDER (a Group object) - creates it if necessary
	///</summary>
	public OSR_Q06_ORDER getORDER() {
	   OSR_Q06_ORDER ret = null;
	   try {
	      ret = (OSR_Q06_ORDER)this.GetStructure("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of OSR_Q06_ORDER
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public OSR_Q06_ORDER getORDER(int rep) { 
	   return (OSR_Q06_ORDER)this.GetStructure("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OSR_Q06_ORDER 
	 */ 
	public int ORDERReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("ORDER").Length; 
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