using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a ROR_ROR message structure (see chapter 4). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: MSA (Message Acknowledgment) <b></b><br>
 * 2: ERR (Error) <b>optional </b><br>
 * 3: ROR_ROR_DEFINITION (a Group object) <b>repeating</b><br>
 * 4: DSC (Continuation Pointer) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
	public class ROR_ROR : AbstractMessage  
	{

		/** 
		 * Creates a new ROR_ROR Group with custom ModelClassFactory.
		 */
		public ROR_ROR(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new ROR_ROR Group with DefaultModelClassFactory. 
		 */ 
		public ROR_ROR() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(MSA), true, false);
				this.add(typeof(ERR), false, false);
				this.add(typeof(ROR_ROR_DEFINITION), true, true);
				this.add(typeof(DSC), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ROR_ROR - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns MSH (Message Header) - creates it if necessary
		 */
		public MSH MSH 
		{ 
			get
			{
				MSH ret = null;
				try 
				{
					ret = (MSH)this.get_Renamed("MSH");
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
		 * Returns MSA (Message Acknowledgment) - creates it if necessary
		 */
		public MSA MSA 
		{ 
			get
			{
				MSA ret = null;
				try 
				{
					ret = (MSA)this.get_Renamed("MSA");
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
		 * Returns ERR (Error) - creates it if necessary
		 */
		public ERR ERR 
		{ 
			get
			{
				ERR ret = null;
				try 
				{
					ret = (ERR)this.get_Renamed("ERR");
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
		 * Returns  first repetition of ROR_ROR_DEFINITION (a Group object) - creates it if necessary
		 */
		public ROR_ROR_DEFINITION getDEFINITION() 
		{
			ROR_ROR_DEFINITION ret = null;
			try 
			{
				ret = (ROR_ROR_DEFINITION)this.get_Renamed("DEFINITION");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of ROR_ROR_DEFINITION
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public ROR_ROR_DEFINITION getDEFINITION(int rep) 
		{ 
			return (ROR_ROR_DEFINITION)this.get_Renamed("DEFINITION", rep);
		}

		/** 
		 * Returns the number of existing repetitions of ROR_ROR_DEFINITION 
		 */ 
		public int DEFINITIONReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("DEFINITION").Length; 
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
		 * Returns DSC (Continuation Pointer) - creates it if necessary
		 */
		public DSC DSC 
		{ 
			get
			{
				DSC ret = null;
				try 
				{
					ret = (DSC)this.get_Renamed("DSC");
				} 
				catch(HL7Exception e) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
		}

	}
}
