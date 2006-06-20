using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v23.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v23.segment
{

	/**
	 * <p>Represents an HL7 MRG message segment. 
	 * This segment has the following fields:</p><p>
	 * MRG-1: Prior Patient ID - Internal (CX)<br> 
	 * MRG-2: Prior Alternate Patient ID (CX)<br> 
	 * MRG-3: Prior Patient Account Number (CX)<br> 
	 * MRG-4: Prior Patient ID - External (CX)<br> 
	 * MRG-5: Prior Visit Number (CX)<br> 
	 * MRG-6: Prior Alternate Visit ID (CX)<br> 
	 * MRG-7: Prior Patient Name (CX)<br> 
	 * </p><p>The get...() methods return data from individual fields.  These methods 
	 * do not throw exceptions and may therefore have to handle exceptions internally.  
	 * If an exception is handled internally, it is logged and null is returned.  
	 * This is not expected to happen - if it does happen this indicates not so much 
	 * an exceptional circumstance as a bug in the code for this class.</p>    
	 */
	[Serializable]
	public class MRG : AbstractSegment  
	{

		/**
		 * Creates a MRG (Merge patient information) segment object that belongs to the given 
		 * message.  
		 */
		public MRG(Group parent, ModelClassFactory factory) : base(parent,factory) 
		{
			Message message = Message;
			try 
			{
				this.add(typeof(CX), true, 0, 20, new System.Object[]{message});
				this.add(typeof(CX), false, 0, 16, new System.Object[]{message});
				this.add(typeof(CX), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CX), false, 1, 16, new System.Object[]{message});
				this.add(typeof(CX), false, 1, 0, new System.Object[]{message});
				this.add(typeof(CX), false, 1, 0, new System.Object[]{message});
				this.add(typeof(CX), false, 1, 0, new System.Object[]{message});
			} 
			catch (HL7Exception he) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
			}
		}

		/**
		* Returns a single repetition of Prior Patient ID - Internal(MRG-1).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public CX getPriorPatientIDInternal(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(1, rep);
				ret = (CX)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Prior Patient ID - Internal (MRG-1).
		 */
		public CX[] getPriorPatientIDInternal() 
		{
			CX[] ret = null;
			try 
			{
				Type[] t = this.getField(1);  
				ret = new CX[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (CX)t[i];
				}
			} 
			catch (HL7Exception he) 
			{
				HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
			} 
			catch (System.Exception cce) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
				throw new System.Exception("An unexpected error ocurred", cce);
			}
			return ret;
		}

		/**
		* Returns a single repetition of Prior Alternate Patient ID(MRG-2).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public CX getPriorAlternatePatientID(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(2, rep);
				ret = (CX)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Prior Alternate Patient ID (MRG-2).
		 */
		public CX[] getPriorAlternatePatientID() 
		{
			CX[] ret = null;
			try 
			{
				Type[] t = this.getField(2);  
				ret = new CX[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (CX)t[i];
				}
			} 
			catch (HL7Exception he) 
			{
				HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
			} 
			catch (System.Exception cce) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
				throw new System.Exception("An unexpected error ocurred", cce);
			}
			return ret;
		}

		/**
		* Returns Prior Patient Account Number(MRG-3).
		*/
		public CX PriorPatientAccountNumber
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (CX)t;
				}
				catch (HL7Exception he) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
					throw new System.Exception("An unexpected error ocurred", he);
				} 
				catch (System.Exception ex) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
					throw new System.Exception("An unexpected error ocurred", ex);
				}
				return ret;
			}
		}

		/**
		* Returns Prior Patient ID - External(MRG-4).
		*/
		public CX PriorPatientIDExternal
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (CX)t;
				}
				catch (HL7Exception he) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
					throw new System.Exception("An unexpected error ocurred", he);
				} 
				catch (System.Exception ex) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
					throw new System.Exception("An unexpected error ocurred", ex);
				}
				return ret;
			}
		}

		/**
		* Returns Prior Visit Number(MRG-5).
		*/
		public CX PriorVisitNumber
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (CX)t;
				}
				catch (HL7Exception he) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
					throw new System.Exception("An unexpected error ocurred", he);
				} 
				catch (System.Exception ex) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
					throw new System.Exception("An unexpected error ocurred", ex);
				}
				return ret;
			}
		}

		/**
		* Returns Prior Alternate Visit ID(MRG-6).
		*/
		public CX PriorAlternateVisitID
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (CX)t;
				}
				catch (HL7Exception he) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
					throw new System.Exception("An unexpected error ocurred", he);
				} 
				catch (System.Exception ex) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
					throw new System.Exception("An unexpected error ocurred", ex);
				}
				return ret;
			}
		}

		/**
		* Returns Prior Patient Name(MRG-7).
		*/
		public CX PriorPatientName
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (CX)t;
				}
				catch (HL7Exception he) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
					throw new System.Exception("An unexpected error ocurred", he);
				} 
				catch (System.Exception ex) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
					throw new System.Exception("An unexpected error ocurred", ex);
				}
				return ret;
			}
		}


	}}