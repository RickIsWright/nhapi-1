using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 SPM message segment. 
 * This segment has the following fields:</p><p>
 * SPM-1: Set ID _ SPM (SI)<br> 
 * SPM-2: Specimen ID (EIP)<br> 
 * SPM-3: Specimen Parent IDs (EIP)<br> 
 * SPM-4: Specimen Type (CWE)<br> 
 * SPM-5: Specimen Type Modifier (CWE)<br> 
 * SPM-6: Specimen Additives (CWE)<br> 
 * SPM-7: Specimen Collection Method (CWE)<br> 
 * SPM-8: Specimen Source Site (CWE)<br> 
 * SPM-9: Specimen Source Site Modifier (CWE)<br> 
 * SPM-10: Specimen Collection Site (CWE)<br> 
 * SPM-11: Specimen Role (CWE)<br> 
 * SPM-12: Specimen Collection Amount (CQ)<br> 
 * SPM-13: Grouped Specimen Count (NM)<br> 
 * SPM-14: Specimen Description (ST)<br> 
 * SPM-15: Specimen Handling Code (CWE)<br> 
 * SPM-16: Specimen Risk Code (CWE)<br> 
 * SPM-17: Specimen Collection Date/Time (DR)<br> 
 * SPM-18: Specimen Received Date/Time (TS)<br> 
 * SPM-19: Specimen Expiration Date/Time (TS)<br> 
 * SPM-20: Specimen Availability (ID)<br> 
 * SPM-21: Specimen Reject Reason (CWE)<br> 
 * SPM-22: Specimen Quality (CWE)<br> 
 * SPM-23: Specimen Appropriateness (CWE)<br> 
 * SPM-24: Specimen Condition (CWE)<br> 
 * SPM-25: Specimen Current Quantity (CQ)<br> 
 * SPM-26: Number of Specimen Containers (NM)<br> 
 * SPM-27: Container Type (CWE)<br> 
 * SPM-28: Container Condition (CWE)<br> 
 * SPM-29: Specimen Child Role (CWE)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class SPM : AbstractSegment  {

  /**
   * Creates a SPM (Specimen) segment object that belongs to the given 
   * message.  
   */
  public SPM(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID _ SPM");
       this.add(typeof(EIP), false, 1, 80, new System.Object[]{message}, "Specimen ID");
       this.add(typeof(EIP), false, 0, 80, new System.Object[]{message}, "Specimen Parent IDs");
       this.add(typeof(CWE), true, 1, 250, new System.Object[]{message}, "Specimen Type");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "Specimen Type Modifier");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "Specimen Additives");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Specimen Collection Method");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Specimen Source Site");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "Specimen Source Site Modifier");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Specimen Collection Site");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "Specimen Role");
       this.add(typeof(CQ), false, 1, 20, new System.Object[]{message}, "Specimen Collection Amount");
       this.add(typeof(NM), false, 1, 6, new System.Object[]{message}, "Grouped Specimen Count");
       this.add(typeof(ST), false, 0, 250, new System.Object[]{message}, "Specimen Description");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "Specimen Handling Code");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "Specimen Risk Code");
       this.add(typeof(DR), false, 1, 26, new System.Object[]{message}, "Specimen Collection Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Specimen Received Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Specimen Expiration Date/Time");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Specimen Availability");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "Specimen Reject Reason");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Specimen Quality");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Specimen Appropriateness");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "Specimen Condition");
       this.add(typeof(CQ), false, 1, 20, new System.Object[]{message}, "Specimen Current Quantity");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Number of Specimen Containers");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Container Type");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Container Condition");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Specimen Child Role");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID _ SPM(SPM-1).
	*/
	public SI SetIDSPM
	{
		get{
			SI ret = null;
			try
			{
			Type t = this.getField(1, 0);
				ret = (SI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Specimen ID(SPM-2).
	*/
	public EIP SpecimenID
	{
		get{
			EIP ret = null;
			try
			{
			Type t = this.getField(2, 0);
				ret = (EIP)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Specimen Parent IDs(SPM-3).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public EIP getSpecimenParentIDs(int rep)
	{
			EIP ret = null;
			try
			{
			Type t = this.getField(3, rep);
				ret = (EIP)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Specimen Parent IDs (SPM-3).
   */
  public EIP[] getSpecimenParentIDs() {
     EIP[] ret = null;
    try {
        Type[] t = this.getField(3);  
        ret = new EIP[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (EIP)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns Specimen Type(SPM-4).
	*/
	public CWE SpecimenType
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(4, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Specimen Type Modifier(SPM-5).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getSpecimenTypeModifier(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(5, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Specimen Type Modifier (SPM-5).
   */
  public CWE[] getSpecimenTypeModifier() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(5);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns a single repetition of Specimen Additives(SPM-6).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getSpecimenAdditives(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(6, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Specimen Additives (SPM-6).
   */
  public CWE[] getSpecimenAdditives() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(6);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns Specimen Collection Method(SPM-7).
	*/
	public CWE SpecimenCollectionMethod
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(7, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Specimen Source Site(SPM-8).
	*/
	public CWE SpecimenSourceSite
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Specimen Source Site Modifier(SPM-9).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getSpecimenSourceSiteModifier(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(9, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Specimen Source Site Modifier (SPM-9).
   */
  public CWE[] getSpecimenSourceSiteModifier() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(9);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns Specimen Collection Site(SPM-10).
	*/
	public CWE SpecimenCollectionSite
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(10, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Specimen Role(SPM-11).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getSpecimenRole(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(11, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Specimen Role (SPM-11).
   */
  public CWE[] getSpecimenRole() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(11);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns Specimen Collection Amount(SPM-12).
	*/
	public CQ SpecimenCollectionAmount
	{
		get{
			CQ ret = null;
			try
			{
			Type t = this.getField(12, 0);
				ret = (CQ)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Grouped Specimen Count(SPM-13).
	*/
	public NM GroupedSpecimenCount
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(13, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Specimen Description(SPM-14).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getSpecimenDescription(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(14, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Specimen Description (SPM-14).
   */
  public ST[] getSpecimenDescription() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(14);  
        ret = new ST[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns a single repetition of Specimen Handling Code(SPM-15).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getSpecimenHandlingCode(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(15, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Specimen Handling Code (SPM-15).
   */
  public CWE[] getSpecimenHandlingCode() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(15);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns a single repetition of Specimen Risk Code(SPM-16).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getSpecimenRiskCode(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(16, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Specimen Risk Code (SPM-16).
   */
  public CWE[] getSpecimenRiskCode() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(16);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns Specimen Collection Date/Time(SPM-17).
	*/
	public DR SpecimenCollectionDateTime
	{
		get{
			DR ret = null;
			try
			{
			Type t = this.getField(17, 0);
				ret = (DR)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Specimen Received Date/Time(SPM-18).
	*/
	public TS SpecimenReceivedDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(18, 0);
				ret = (TS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Specimen Expiration Date/Time(SPM-19).
	*/
	public TS SpecimenExpirationDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(19, 0);
				ret = (TS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Specimen Availability(SPM-20).
	*/
	public ID SpecimenAvailability
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(20, 0);
				ret = (ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Specimen Reject Reason(SPM-21).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getSpecimenRejectReason(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(21, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Specimen Reject Reason (SPM-21).
   */
  public CWE[] getSpecimenRejectReason() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(21);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns Specimen Quality(SPM-22).
	*/
	public CWE SpecimenQuality
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(22, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Specimen Appropriateness(SPM-23).
	*/
	public CWE SpecimenAppropriateness
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(23, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Specimen Condition(SPM-24).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getSpecimenCondition(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(24, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Specimen Condition (SPM-24).
   */
  public CWE[] getSpecimenCondition() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(24);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns Specimen Current Quantity(SPM-25).
	*/
	public CQ SpecimenCurrentQuantity
	{
		get{
			CQ ret = null;
			try
			{
			Type t = this.getField(25, 0);
				ret = (CQ)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Number of Specimen Containers(SPM-26).
	*/
	public NM NumberOfSpecimenContainers
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(26, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Container Type(SPM-27).
	*/
	public CWE ContainerType
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(27, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Container Condition(SPM-28).
	*/
	public CWE ContainerCondition
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(28, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Specimen Child Role(SPM-29).
	*/
	public CWE SpecimenChildRole
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(29, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }


}}