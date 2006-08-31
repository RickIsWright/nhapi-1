using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
///<summary>
///Represents the ORN_O08_RESPONSE Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
/// * 0: ORN_O08_PATIENT (a Group object) optional 
/// * 1: ORN_O08_ORDER (a Group object) repeating
///</summary>
[Serializable]
public class ORN_O08_RESPONSE : AbstractGroup {

	///<summary> 
	/// Creates a new ORN_O08_RESPONSE Group.
	///</summary>
	public ORN_O08_RESPONSE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORN_O08_PATIENT), false, false);
	      this.add(typeof(ORN_O08_ORDER), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORN_O08_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns ORN_O08_PATIENT (a Group object) - creates it if necessary
	///</summary>
	public ORN_O08_PATIENT PATIENT { 
get{
	   ORN_O08_PATIENT ret = null;
	   try {
	      ret = (ORN_O08_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of ORN_O08_ORDER (a Group object) - creates it if necessary
	///</summary>
	public ORN_O08_ORDER getORDER() {
	   ORN_O08_ORDER ret = null;
	   try {
	      ret = (ORN_O08_ORDER)this.GetStructure("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of ORN_O08_ORDER
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public ORN_O08_ORDER getORDER(int rep) { 
	   return (ORN_O08_ORDER)this.GetStructure("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORN_O08_ORDER 
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