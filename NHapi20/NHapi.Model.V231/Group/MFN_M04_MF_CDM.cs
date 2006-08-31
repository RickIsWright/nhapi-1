using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
    ///<summary>
    ///Represents the MFN_M04_MF_CDM Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: MFE (MFE - master file entry segment) 
    /// * 1: CDM (CDM -  charge description master segment) 
    /// * 2: PRC (PRC -  pricing segment) optional repeating
    ///</summary>
    [Serializable]
    public class MFN_M04_MF_CDM : AbstractGroup
    {

        ///<summary> 
        /// Creates a new MFN_M04_MF_CDM Group.
        ///</summary>
        public MFN_M04_MF_CDM(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(MFE), true, false);
                this.add(typeof(CDM), true, false);
                this.add(typeof(PRC), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M04_MF_CDM - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns MFE (MFE - master file entry segment) - creates it if necessary
        ///</summary>
        public MFE MFE
        {
            get
            {
                MFE ret = null;
                try
                {
                    ret = (MFE)this.GetStructure("MFE");
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
        /// Returns CDM (CDM -  charge description master segment) - creates it if necessary
        ///</summary>
        public CDM CDM
        {
            get
            {
                CDM ret = null;
                try
                {
                    ret = (CDM)this.GetStructure("CDM");
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
        /// Returns  first repetition of PRC (PRC -  pricing segment) - creates it if necessary
        ///</summary>
        public PRC getPRC()
        {
            PRC ret = null;
            try
            {
                ret = (PRC)this.GetStructure("PRC");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of PRC
        /// * (PRC -  pricing segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public PRC getPRC(int rep)
        {
            return (PRC)this.GetStructure("PRC", rep);
        }

        /** 
         * Returns the number of existing repetitions of PRC 
         */
        public int PRCReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("PRC").Length;
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
