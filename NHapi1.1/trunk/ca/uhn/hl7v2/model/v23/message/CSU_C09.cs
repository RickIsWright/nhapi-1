using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.group;
using ca.uhn.hl7v2.model.v23.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a CSU_C09 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message header segment) <b></b><br>
 * 1: CSU_C09_PATIENT (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.message

{
	public class CSU_C09 : AbstractMessage  
	{

		/** 
		 * Creates a new CSU_C09 Group with custom ModelClassFactory.
		 */
		public CSU_C09(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new CSU_C09 Group with DefaultModelClassFactory. 
		 */ 
		public CSU_C09() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(CSU_C09_PATIENT), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating CSU_C09 - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns MSH (Message header segment) - creates it if necessary
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
		 * Returns  first repetition of CSU_C09_PATIENT (a Group object) - creates it if necessary
		 */
		public CSU_C09_PATIENT getPATIENT() 
		{
			CSU_C09_PATIENT ret = null;
			try 
			{
				ret = (CSU_C09_PATIENT)this.get_Renamed("PATIENT");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of CSU_C09_PATIENT
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public CSU_C09_PATIENT getPATIENT(int rep) 
		{ 
			return (CSU_C09_PATIENT)this.get_Renamed("PATIENT", rep);
		}

		/** 
		 * Returns the number of existing repetitions of CSU_C09_PATIENT 
		 */ 
		public int PATIENTReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("PATIENT").Length; 
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
