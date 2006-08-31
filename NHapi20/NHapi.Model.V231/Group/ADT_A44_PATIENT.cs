using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
    ///<summary>
    ///Represents the ADT_A44_PATIENT Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: PID (PID - patient identification segment) 
    /// * 1: PD1 (PD1 - patient additional demographic segment) optional 
    /// * 2: MRG (MRG - merge patient information segment-) 
    ///</summary>
    [Serializable]
    public class ADT_A44_PATIENT : AbstractGroup
    {

        ///<summary> 
        /// Creates a new ADT_A44_PATIENT Group.
        ///</summary>
        public ADT_A44_PATIENT(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(PID), true, false);
                this.add(typeof(PD1), false, false);
                this.add(typeof(MRG), true, false);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ADT_A44_PATIENT - this is probably a bug in the source code generator.", e);
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
        /// Returns MRG (MRG - merge patient information segment-) - creates it if necessary
        ///</summary>
        public MRG MRG
        {
            get
            {
                MRG ret = null;
                try
                {
                    ret = (MRG)this.GetStructure("MRG");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

    }
}
