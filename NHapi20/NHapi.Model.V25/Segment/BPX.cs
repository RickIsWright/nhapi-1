using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V25.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V25.Segment{

///<summary>
/// Represents an HL7 BPX message segment. 
/// This segment has the following fields:
/// * BPX-1: Set ID _ BPX (SI)
/// * BPX-2: BP Dispense Status (CWE)
/// * BPX-3: BP Status (ID)
/// * BPX-4: BP Date/Time of Status (TS)
/// * BPX-5: BC Donation ID (EI)
/// * BPX-6: BC Component (CNE)
/// * BPX-7: BC Donation Type / Intended Use (CNE)
/// * BPX-8: CP Commercial Product (CWE)
/// * BPX-9: CP Manufacturer (XON)
/// * BPX-10: CP Lot Number (EI)
/// * BPX-11: BP Blood Group (CNE)
/// * BPX-12: BC Special Testing (CNE)
/// * BPX-13: BP Expiration Date/Time (TS)
/// * BPX-14: BP Quantity (NM)
/// * BPX-15: BP Amount (NM)
/// * BPX-16: BP Units (CE)
/// * BPX-17: BP Unique ID (EI)
/// * BPX-18: BP Actual Dispensed To Location (PL)
/// * BPX-19: BP Actual Dispensed To Address (XAD)
/// * BPX-20: BP Dispensed to Receiver (XCN)
/// * BPX-21: BP Dispensing Individual (XCN)
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class BPX : AbstractSegment  {

  /**
   * Creates a BPX (Blood product dispense status) segment object that belongs to the given 
   * message.  
   */
	public BPX(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "Set ID _ BPX");
       this.add(typeof(CWE), true, 1, 250, new System.Object[]{message}, "BP Dispense Status");
       this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 511}, "BP Status");
       this.add(typeof(TS), true, 1, 26, new System.Object[]{message}, "BP Date/Time of Status");
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message}, "BC Donation ID");
       this.add(typeof(CNE), false, 1, 250, new System.Object[]{message}, "BC Component");
       this.add(typeof(CNE), false, 1, 250, new System.Object[]{message}, "BC Donation Type / Intended Use");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "CP Commercial Product");
       this.add(typeof(XON), false, 1, 250, new System.Object[]{message}, "CP Manufacturer");
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message}, "CP Lot Number");
       this.add(typeof(CNE), false, 1, 250, new System.Object[]{message}, "BP Blood Group");
       this.add(typeof(CNE), false, 0, 250, new System.Object[]{message}, "BC Special Testing");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "BP Expiration Date/Time");
       this.add(typeof(NM), true, 1, 5, new System.Object[]{message}, "BP Quantity");
       this.add(typeof(NM), false, 1, 5, new System.Object[]{message}, "BP Amount");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "BP Units");
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message}, "BP Unique ID");
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message}, "BP Actual Dispensed To Location");
       this.add(typeof(XAD), false, 1, 250, new System.Object[]{message}, "BP Actual Dispensed To Address");
       this.add(typeof(XCN), false, 1, 250, new System.Object[]{message}, "BP Dispensed to Receiver");
       this.add(typeof(XCN), false, 1, 250, new System.Object[]{message}, "BP Dispensing Individual");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Set ID _ BPX(BPX-1).
	///</summary>
	public SI SetIDBPX
	{
		get{
			SI ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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

	///<summary>
	/// Returns BP Dispense Status(BPX-2).
	///</summary>
	public CWE BPDispenseStatus
	{
		get{
			CWE ret = null;
			try
			{
			IType t = this.GetField(2, 0);
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

	///<summary>
	/// Returns BP Status(BPX-3).
	///</summary>
	public ID BPStatus
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(3, 0);
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

	///<summary>
	/// Returns BP Date/Time of Status(BPX-4).
	///</summary>
	public TS BPDateTimeOfStatus
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(4, 0);
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

	///<summary>
	/// Returns BC Donation ID(BPX-5).
	///</summary>
	public EI BCDonationID
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(5, 0);
				ret = (EI)t;
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

	///<summary>
	/// Returns BC Component(BPX-6).
	///</summary>
	public CNE BCComponent
	{
		get{
			CNE ret = null;
			try
			{
			IType t = this.GetField(6, 0);
				ret = (CNE)t;
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

	///<summary>
	/// Returns BC Donation Type / Intended Use(BPX-7).
	///</summary>
	public CNE BCDonationTypeIntendedUse
	{
		get{
			CNE ret = null;
			try
			{
			IType t = this.GetField(7, 0);
				ret = (CNE)t;
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

	///<summary>
	/// Returns CP Commercial Product(BPX-8).
	///</summary>
	public CWE CPCommercialProduct
	{
		get{
			CWE ret = null;
			try
			{
			IType t = this.GetField(8, 0);
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

	///<summary>
	/// Returns CP Manufacturer(BPX-9).
	///</summary>
	public XON CPManufacturer
	{
		get{
			XON ret = null;
			try
			{
			IType t = this.GetField(9, 0);
				ret = (XON)t;
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

	///<summary>
	/// Returns CP Lot Number(BPX-10).
	///</summary>
	public EI CPLotNumber
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(10, 0);
				ret = (EI)t;
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

	///<summary>
	/// Returns BP Blood Group(BPX-11).
	///</summary>
	public CNE BPBloodGroup
	{
		get{
			CNE ret = null;
			try
			{
			IType t = this.GetField(11, 0);
				ret = (CNE)t;
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

	///<summary>
	/// Returns a single repetition of BC Special Testing(BPX-12).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CNE getBCSpecialTesting(int rep)
	{
			CNE ret = null;
			try
			{
			IType t = this.GetField(12, rep);
				ret = (CNE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of BC Special Testing (BPX-12).
   ///</summary>
  public CNE[] getBCSpecialTesting() {
     CNE[] ret = null;
    try {
        IType[] t = this.GetField(12);  
        ret = new CNE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CNE)t[i];
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

	///<summary>
	/// Returns BP Expiration Date/Time(BPX-13).
	///</summary>
	public TS BPExpirationDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(13, 0);
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

	///<summary>
	/// Returns BP Quantity(BPX-14).
	///</summary>
	public NM BPQuantity
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(14, 0);
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

	///<summary>
	/// Returns BP Amount(BPX-15).
	///</summary>
	public NM BPAmount
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(15, 0);
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

	///<summary>
	/// Returns BP Units(BPX-16).
	///</summary>
	public CE BPUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(16, 0);
				ret = (CE)t;
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

	///<summary>
	/// Returns BP Unique ID(BPX-17).
	///</summary>
	public EI BPUniqueID
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(17, 0);
				ret = (EI)t;
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

	///<summary>
	/// Returns BP Actual Dispensed To Location(BPX-18).
	///</summary>
	public PL BPActualDispensedToLocation
	{
		get{
			PL ret = null;
			try
			{
			IType t = this.GetField(18, 0);
				ret = (PL)t;
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

	///<summary>
	/// Returns BP Actual Dispensed To Address(BPX-19).
	///</summary>
	public XAD BPActualDispensedToAddress
	{
		get{
			XAD ret = null;
			try
			{
			IType t = this.GetField(19, 0);
				ret = (XAD)t;
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

	///<summary>
	/// Returns BP Dispensed to Receiver(BPX-20).
	///</summary>
	public XCN BPDispensedToReceiver
	{
		get{
			XCN ret = null;
			try
			{
			IType t = this.GetField(20, 0);
				ret = (XCN)t;
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

	///<summary>
	/// Returns BP Dispensing Individual(BPX-21).
	///</summary>
	public XCN BPDispensingIndividual
	{
		get{
			XCN ret = null;
			try
			{
			IType t = this.GetField(21, 0);
				ret = (XCN)t;
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