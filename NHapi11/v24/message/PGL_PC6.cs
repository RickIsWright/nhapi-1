using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a PGL_PC6 message structure (see chapter 12). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: PID (Patient identification) <b></b><br>
 * 2: PGL_PC6_PATIENT_VISIT (a Group object) <b>optional </b><br>
 * 3: PGL_PC6_GOAL (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
	public class PGL_PC6 : AbstractMessage  
	{

		/** 
		 * Creates a new PGL_PC6 Group with custom ModelClassFactory.
		 */
		public PGL_PC6(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new PGL_PC6 Group with DefaultModelClassFactory. 
		 */ 
		public PGL_PC6() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(PID), true, false);
				this.add(typeof(PGL_PC6_PATIENT_VISIT), false, false);
				this.add(typeof(PGL_PC6_GOAL), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PGL_PC6 - this is probably a bug in the source code generator.", e);
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
		 * Returns PID (Patient identification) - creates it if necessary
		 */
		public PID PID 
		{ 
			get
			{
				PID ret = null;
				try 
				{
					ret = (PID)this.get_Renamed("PID");
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
		 * Returns PGL_PC6_PATIENT_VISIT (a Group object) - creates it if necessary
		 */
		public PGL_PC6_PATIENT_VISIT PATIENT_VISIT 
		{ 
			get
			{
				PGL_PC6_PATIENT_VISIT ret = null;
				try 
				{
					ret = (PGL_PC6_PATIENT_VISIT)this.get_Renamed("PATIENT_VISIT");
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
		 * Returns  first repetition of PGL_PC6_GOAL (a Group object) - creates it if necessary
		 */
		public PGL_PC6_GOAL getGOAL() 
		{
			PGL_PC6_GOAL ret = null;
			try 
			{
				ret = (PGL_PC6_GOAL)this.get_Renamed("GOAL");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of PGL_PC6_GOAL
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public PGL_PC6_GOAL getGOAL(int rep) 
		{ 
			return (PGL_PC6_GOAL)this.get_Renamed("GOAL", rep);
		}

		/** 
		 * Returns the number of existing repetitions of PGL_PC6_GOAL 
		 */ 
		public int GOALReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("GOAL").Length; 
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
