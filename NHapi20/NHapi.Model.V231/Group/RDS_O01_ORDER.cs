using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
    ///<summary>
    ///Represents the RDS_O01_ORDER Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: ORC (ORC - common order segment) 
    /// * 1: RDS_O01_ORDER_DETAIL (a Group object) optional 
    /// * 2: RDS_O01_ENCODING (a Group object) optional 
    /// * 3: RXD (RXD - pharmacy/treatment dispense segment) 
    /// * 4: RXR (RXR - pharmacy/treatment route segment) repeating
    /// * 5: RXC (RXC - pharmacy/treatment component order segment) optional repeating
    /// * 6: RDS_O01_OBSERVATION (a Group object) optional repeating
    ///</summary>
    [Serializable]
    public class RDS_O01_ORDER : AbstractGroup
    {

        ///<summary> 
        /// Creates a new RDS_O01_ORDER Group.
        ///</summary>
        public RDS_O01_ORDER(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(ORC), true, false);
                this.add(typeof(RDS_O01_ORDER_DETAIL), false, false);
                this.add(typeof(RDS_O01_ENCODING), false, false);
                this.add(typeof(RXD), true, false);
                this.add(typeof(RXR), true, true);
                this.add(typeof(RXC), false, true);
                this.add(typeof(RDS_O01_OBSERVATION), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RDS_O01_ORDER - this is probably a bug in the source code generator.", e);
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
        /// Returns RDS_O01_ORDER_DETAIL (a Group object) - creates it if necessary
        ///</summary>
        public RDS_O01_ORDER_DETAIL ORDER_DETAIL
        {
            get
            {
                RDS_O01_ORDER_DETAIL ret = null;
                try
                {
                    ret = (RDS_O01_ORDER_DETAIL)this.GetStructure("ORDER_DETAIL");
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
        /// Returns RDS_O01_ENCODING (a Group object) - creates it if necessary
        ///</summary>
        public RDS_O01_ENCODING ENCODING
        {
            get
            {
                RDS_O01_ENCODING ret = null;
                try
                {
                    ret = (RDS_O01_ENCODING)this.GetStructure("ENCODING");
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
        /// Returns RXD (RXD - pharmacy/treatment dispense segment) - creates it if necessary
        ///</summary>
        public RXD RXD
        {
            get
            {
                RXD ret = null;
                try
                {
                    ret = (RXD)this.GetStructure("RXD");
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
        /// Returns  first repetition of RXR (RXR - pharmacy/treatment route segment) - creates it if necessary
        ///</summary>
        public RXR getRXR()
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

        ///<summary>
        ///Returns a specific repetition of RXR
        /// * (RXR - pharmacy/treatment route segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public RXR getRXR(int rep)
        {
            return (RXR)this.GetStructure("RXR", rep);
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
                    reps = this.GetAll("RXR").Length;
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
        /// Returns  first repetition of RXC (RXC - pharmacy/treatment component order segment) - creates it if necessary
        ///</summary>
        public RXC getRXC()
        {
            RXC ret = null;
            try
            {
                ret = (RXC)this.GetStructure("RXC");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of RXC
        /// * (RXC - pharmacy/treatment component order segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public RXC getRXC(int rep)
        {
            return (RXC)this.GetStructure("RXC", rep);
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
                    reps = this.GetAll("RXC").Length;
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
        /// Returns  first repetition of RDS_O01_OBSERVATION (a Group object) - creates it if necessary
        ///</summary>
        public RDS_O01_OBSERVATION getOBSERVATION()
        {
            RDS_O01_OBSERVATION ret = null;
            try
            {
                ret = (RDS_O01_OBSERVATION)this.GetStructure("OBSERVATION");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of RDS_O01_OBSERVATION
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public RDS_O01_OBSERVATION getOBSERVATION(int rep)
        {
            return (RDS_O01_OBSERVATION)this.GetStructure("OBSERVATION", rep);
        }

        /** 
         * Returns the number of existing repetitions of RDS_O01_OBSERVATION 
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

    }
}