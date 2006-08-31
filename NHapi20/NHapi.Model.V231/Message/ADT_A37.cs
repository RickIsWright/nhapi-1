using System;
using NHapi.Base.Log;
using NHapi.Model.V231.Group;
using NHapi.Model.V231.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V231.Message
{
    ///<summary>
    /// Represents a ADT_A37 message structure (see chapter [AAA]). This structure contains the 
    /// following elements:
    /// * 0: MSH (MSH - message header segment) 
    /// * 1: EVN (EVN - event type segment) 
    /// * 2: PID (PID - patient identification segment) 
    /// * 3: PD1 (PD1 - patient additional demographic segment) optional 
    /// * 4: PV1 (PV1 - patient visit segment-) optional 
    /// * 5: DB1 (DB1 - Disability segment) optional repeating
    /// * 6: PID (PID - patient identification segment) 
    /// * 7: PD1 (PD1 - patient additional demographic segment) optional 
    /// * 8: PV1 (PV1 - patient visit segment-) optional 
    /// * 9: DB1 (DB1 - Disability segment) optional repeating
    ///</summary>
    [Serializable]
    public class ADT_A37 : AbstractMessage
    {

        ///<summary> 
        /// Creates a new ADT_A37 Group with custom IModelClassFactory.
        ///</summary>
        public ADT_A37(IModelClassFactory factory)
            : base(factory)
        {
            init(factory);
        }

        ///<summary>
        /// Creates a new ADT_A37 Group with DefaultModelClassFactory. 
        ///</summary> 
        public ADT_A37()
            : base(new DefaultModelClassFactory())
        {
            init(new DefaultModelClassFactory());
        }

        ///<summary>
        /// initalize method for ADT_A37.  This does the segment setup for the message. 
        ///</summary> 
        private void init(IModelClassFactory factory)
        {
            try
            {
                this.add(typeof(MSH), true, false);
                this.add(typeof(EVN), true, false);
                this.add(typeof(PID), true, false);
                this.add(typeof(PD1), false, false);
                this.add(typeof(PV1), false, false);
                this.add(typeof(DB1), false, true);
                this.add(typeof(PID), true, false);
                this.add(typeof(PD1), false, false);
                this.add(typeof(PV1), false, false);
                this.add(typeof(DB1), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ADT_A37 - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns MSH (MSH - message header segment) - creates it if necessary
        ///</summary>
        public MSH MSH
        {
            get
            {
                MSH ret = null;
                try
                {
                    ret = (MSH)this.GetStructure("MSH");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns EVN (EVN - event type segment) - creates it if necessary
        ///</summary>
        public EVN EVN
        {
            get
            {
                EVN ret = null;
                try
                {
                    ret = (EVN)this.GetStructure("EVN");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns PID (PID - patient identification segment) - creates it if necessary
        ///</summary>
        public PID PID
        {
            get
            {
                PID ret = null;
                try
                {
                    ret = (PID)this.GetStructure("PID");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns PD1 (PD1 - patient additional demographic segment) - creates it if necessary
        ///</summary>
        public PD1 PD1
        {
            get
            {
                PD1 ret = null;
                try
                {
                    ret = (PD1)this.GetStructure("PD1");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns PV1 (PV1 - patient visit segment-) - creates it if necessary
        ///</summary>
        public PV1 PV1
        {
            get
            {
                PV1 ret = null;
                try
                {
                    ret = (PV1)this.GetStructure("PV1");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns  first repetition of DB1 (DB1 - Disability segment) - creates it if necessary
        ///</summary>
        public DB1 getDB1()
        {
            DB1 ret = null;
            try
            {
                ret = (DB1)this.GetStructure("DB1");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of DB1
        /// * (DB1 - Disability segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public DB1 getDB1(int rep)
        {
            return (DB1)this.GetStructure("DB1", rep);
        }

        /** 
         * Returns the number of existing repetitions of DB1 
         */
        public int DB1Reps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("DB1").Length;
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

        ///<summary>
        /// Returns PID2 (PID - patient identification segment) - creates it if necessary
        ///</summary>
        public PID PID2
        {
            get
            {
                PID ret = null;
                try
                {
                    ret = (PID)this.GetStructure("PID2");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns PD12 (PD1 - patient additional demographic segment) - creates it if necessary
        ///</summary>
        public PD1 PD12
        {
            get
            {
                PD1 ret = null;
                try
                {
                    ret = (PD1)this.GetStructure("PD12");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns PV12 (PV1 - patient visit segment-) - creates it if necessary
        ///</summary>
        public PV1 PV12
        {
            get
            {
                PV1 ret = null;
                try
                {
                    ret = (PV1)this.GetStructure("PV12");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns  first repetition of DB12 (DB1 - Disability segment) - creates it if necessary
        ///</summary>
        public DB1 getDB12()
        {
            DB1 ret = null;
            try
            {
                ret = (DB1)this.GetStructure("DB12");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of DB12
        /// * (DB1 - Disability segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public DB1 getDB12(int rep)
        {
            return (DB1)this.GetStructure("DB12", rep);
        }

        /** 
         * Returns the number of existing repetitions of DB12 
         */
        public int DB12Reps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("DB12").Length;
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
