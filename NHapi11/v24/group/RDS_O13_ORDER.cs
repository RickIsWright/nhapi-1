using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RDS_O13_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: RDS_O13_ORDER_DETAIL (a Group object) <b>optional </b><br>
 * 2: RDS_O13_ENCODING (a Group object) <b>optional </b><br>
 * 3: RXD (Pharmacy/Treatment Dispense) <b></b><br>
 * 4: RXR (Pharmacy/Treatment Route) <b>repeating</b><br>
 * 5: RXC (Pharmacy/Treatment Component Order) <b>optional repeating</b><br>
 * 6: RDS_O13_OBSERVATION (a Group object) <b>optional repeating</b><br>
 * 7: FT1 (Financial Transaction) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class RDS_O13_ORDER : AbstractGroup 
	{

		/** 
		 * Creates a new RDS_O13_ORDER Group.
		 */
		public RDS_O13_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RDS_O13_ORDER_DETAIL), false, false);
				this.add(typeof(RDS_O13_ENCODING), false, false);
				this.add(typeof(RXD), true, false);
				this.add(typeof(RXR), true, true);
				this.add(typeof(RXC), false, true);
				this.add(typeof(RDS_O13_OBSERVATION), false, true);
				this.add(typeof(FT1), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RDS_O13_ORDER - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns ORC (Common Order) - creates it if necessary
		 */
		public ORC ORC 
		{ 
			get
			{
				ORC ret = null;
				try 
				{
					ret = (ORC)this.get_Renamed("ORC");
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
		 * Returns RDS_O13_ORDER_DETAIL (a Group object) - creates it if necessary
		 */
		public RDS_O13_ORDER_DETAIL ORDER_DETAIL 
		{ 
			get
			{
				RDS_O13_ORDER_DETAIL ret = null;
				try 
				{
					ret = (RDS_O13_ORDER_DETAIL)this.get_Renamed("ORDER_DETAIL");
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
		 * Returns RDS_O13_ENCODING (a Group object) - creates it if necessary
		 */
		public RDS_O13_ENCODING ENCODING 
		{ 
			get
			{
				RDS_O13_ENCODING ret = null;
				try 
				{
					ret = (RDS_O13_ENCODING)this.get_Renamed("ENCODING");
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
		 * Returns RXD (Pharmacy/Treatment Dispense) - creates it if necessary
		 */
		public RXD RXD 
		{ 
			get
			{
				RXD ret = null;
				try 
				{
					ret = (RXD)this.get_Renamed("RXD");
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
		 * Returns  first repetition of RXR (Pharmacy/Treatment Route) - creates it if necessary
		 */
		public RXR getRXR() 
		{
			RXR ret = null;
			try 
			{
				ret = (RXR)this.get_Renamed("RXR");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of RXR
		 * (Pharmacy/Treatment Route) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RXR getRXR(int rep) 
		{ 
			return (RXR)this.get_Renamed("RXR", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RXR 
		 */ 
		public int RXRReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("RXR").Length; 
				} 
				catch (HL7Exception e) 
				{ 
					string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
					HapiLogFactory.getHapiLog(GetType()).error(message, e); 
					throw new System.Exception(message);
				} 
				return reps; 
			}
		} 

		/**
		 * Returns  first repetition of RXC (Pharmacy/Treatment Component Order) - creates it if necessary
		 */
		public RXC getRXC() 
		{
			RXC ret = null;
			try 
			{
				ret = (RXC)this.get_Renamed("RXC");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of RXC
		 * (Pharmacy/Treatment Component Order) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RXC getRXC(int rep) 
		{ 
			return (RXC)this.get_Renamed("RXC", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RXC 
		 */ 
		public int RXCReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("RXC").Length; 
				} 
				catch (HL7Exception e) 
				{ 
					string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
					HapiLogFactory.getHapiLog(GetType()).error(message, e); 
					throw new System.Exception(message);
				} 
				return reps; 
			}
		} 

		/**
		 * Returns  first repetition of RDS_O13_OBSERVATION (a Group object) - creates it if necessary
		 */
		public RDS_O13_OBSERVATION getOBSERVATION() 
		{
			RDS_O13_OBSERVATION ret = null;
			try 
			{
				ret = (RDS_O13_OBSERVATION)this.get_Renamed("OBSERVATION");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of RDS_O13_OBSERVATION
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RDS_O13_OBSERVATION getOBSERVATION(int rep) 
		{ 
			return (RDS_O13_OBSERVATION)this.get_Renamed("OBSERVATION", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RDS_O13_OBSERVATION 
		 */ 
		public int OBSERVATIONReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("OBSERVATION").Length; 
				} 
				catch (HL7Exception e) 
				{ 
					string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
					HapiLogFactory.getHapiLog(GetType()).error(message, e); 
					throw new System.Exception(message);
				} 
				return reps; 
			}
		} 

		/**
		 * Returns  first repetition of FT1 (Financial Transaction) - creates it if necessary
		 */
		public FT1 getFT1() 
		{
			FT1 ret = null;
			try 
			{
				ret = (FT1)this.get_Renamed("FT1");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of FT1
		 * (Financial Transaction) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public FT1 getFT1(int rep) 
		{ 
			return (FT1)this.get_Renamed("FT1", rep);
		}

		/** 
		 * Returns the number of existing repetitions of FT1 
		 */ 
		public int FT1Reps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("FT1").Length; 
				} 
				catch (HL7Exception e) 
				{ 
					string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
					HapiLogFactory.getHapiLog(GetType()).error(message, e); 
					throw new System.Exception(message);
				} 
				return reps; 
			}
		} 

	}
}
