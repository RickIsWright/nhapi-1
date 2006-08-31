using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
    ///<summary>
    ///Represents the RAS_O01_ORDER Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: ORC (ORC - common order segment) 
    /// * 1: RAS_O01_ORDER_DETAIL (a Group object) optional 
    /// * 2: RAS_O01_ENCODING (a Group object) optional 
    /// * 3: RXA (RXA - pharmacy/treatment administration segment) repeating
    /// * 4: RXR (RXR - pharmacy/treatment route segment) 
    /// * 5: RAS_O01_OBSERVATION (a Group object) optional repeating
    /// * 6: CTI (CTI - clinical trial identification segment) optional repeating
    ///</summary>
    [Serializable]
    public class RAS_O01_ORDER : AbstractGroup
    {

        ///<summary> 
        /// Creates a new RAS_O01_ORDER Group.
        ///</summary>
        public RAS_O01_ORDER(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(ORC), true, false);
                this.add(typeof(RAS_O01_ORDER_DETAIL), false, false);
                this.add(typeof(RAS_O01_ENCODING), false, false);
                this.add(typeof(RXA), true, true);
                this.add(typeof(RXR), true, false);
                this.add(typeof(RAS_O01_OBSERVATION), false, true);
                this.add(typeof(CTI), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RAS_O01_ORDER - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns ORC (ORC - common order segment) - creates it if necessary
        ///</summary>
        public ORC ORC
        {
            get
            {
                ORC ret = null;
                try
                {
                    ret = (ORC)this.GetStructure("ORC");
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
        /// Returns RAS_O01_ORDER_DETAIL (a Group object) - creates it if necessary
        ///</summary>
        public RAS_O01_ORDER_DETAIL ORDER_DETAIL
        {
            get
            {
                RAS_O01_ORDER_DETAIL ret = null;
                try
                {
                    ret = (RAS_O01_ORDER_DETAIL)this.GetStructure("ORDER_DETAIL");
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
        /// Returns RAS_O01_ENCODING (a Group object) - creates it if necessary
        ///</summary>
        public RAS_O01_ENCODING ENCODING
        {
            get
            {
                RAS_O01_ENCODING ret = null;
                try
                {
                    ret = (RAS_O01_ENCODING)this.GetStructure("ENCODING");
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
        /// Returns  first repetition of RXA (RXA - pharmacy/treatment administration segment) - creates it if necessary
        ///</summary>
        public RXA getRXA()
        {
            RXA ret = null;
            try
            {
                ret = (RXA)this.GetStructure("RXA");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of RXA
        /// * (RXA - pharmacy/treatment administration segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public RXA getRXA(int rep)
        {
            return (RXA)this.GetStructure("RXA", rep);
        }

        /** 
         * Returns the number of existing repetitions of RXA 
         */
        public int RXAReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("RXA").Length;
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
        /// Returns RXR (RXR - pharmacy/treatment route segment) - creates it if necessary
        ///</summary>
        public RXR RXR
        {
            get
            {
                RXR ret = null;
                try
                {
                    ret = (RXR)this.GetStructure("RXR");
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
        /// Returns  first repetition of RAS_O01_OBSERVATION (a Group object) - creates it if necessary
        ///</summary>
        public RAS_O01_OBSERVATION getOBSERVATION()
        {
            RAS_O01_OBSERVATION ret = null;
            try
            {
                ret = (RAS_O01_OBSERVATION)this.GetStructure("OBSERVATION");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of RAS_O01_OBSERVATION
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public RAS_O01_OBSERVATION getOBSERVATION(int rep)
        {
            return (RAS_O01_OBSERVATION)this.GetStructure("OBSERVATION", rep);
        }

        /** 
         * Returns the number of existing repetitions of RAS_O01_OBSERVATION 
         */
        public int OBSERVATIONReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("OBSERVATION").Length;
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
        /// Returns  first repetition of CTI (CTI - clinical trial identification segment) - creates it if necessary
        ///</summary>
        public CTI getCTI()
        {
            CTI ret = null;
            try
            {
                ret = (CTI)this.GetStructure("CTI");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of CTI
        /// * (CTI - clinical trial identification segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public CTI getCTI(int rep)
        {
            return (CTI)this.GetStructure("CTI", rep);
        }

        /** 
         * Returns the number of existing repetitions of CTI 
         */
        public int CTIReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("CTI").Length;
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
