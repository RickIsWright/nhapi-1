using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
    ///<summary>
    ///Represents the RGV_O01_GIVE Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: RXG (RXG - pharmacy/treatment give segment) 
    /// * 1: RXR (RXR - pharmacy/treatment route segment) repeating
    /// * 2: RXC (RXC - pharmacy/treatment component order segment) optional repeating
    /// * 3: RGV_O01_OBSERVATION (a Group object) repeating
    ///</summary>
    [Serializable]
    public class RGV_O01_GIVE : AbstractGroup
    {

        ///<summary> 
        /// Creates a new RGV_O01_GIVE Group.
        ///</summary>
        public RGV_O01_GIVE(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(RXG), true, false);
                this.add(typeof(RXR), true, true);
                this.add(typeof(RXC), false, true);
                this.add(typeof(RGV_O01_OBSERVATION), true, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RGV_O01_GIVE - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns RXG (RXG - pharmacy/treatment give segment) - creates it if necessary
        ///</summary>
        public RXG RXG
        {
            get
            {
                RXG ret = null;
                try
                {
                    ret = (RXG)this.GetStructure("RXG");
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
        /// Returns  first repetition of RGV_O01_OBSERVATION (a Group object) - creates it if necessary
        ///</summary>
        public RGV_O01_OBSERVATION getOBSERVATION()
        {
            RGV_O01_OBSERVATION ret = null;
            try
            {
                ret = (RGV_O01_OBSERVATION)this.GetStructure("OBSERVATION");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of RGV_O01_OBSERVATION
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public RGV_O01_OBSERVATION getOBSERVATION(int rep)
        {
            return (RGV_O01_OBSERVATION)this.GetStructure("OBSERVATION", rep);
        }

        /** 
         * Returns the number of existing repetitions of RGV_O01_OBSERVATION 
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