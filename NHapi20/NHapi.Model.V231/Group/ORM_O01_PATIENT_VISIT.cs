using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
    ///<summary>
    ///Represents the ORM_O01_PATIENT_VISIT Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: PV1 (PV1 - patient visit segment-) 
    /// * 1: PV2 (PV2 - patient visit - additional information segment) optional 
    ///</summary>
    [Serializable]
    public class ORM_O01_PATIENT_VISIT : AbstractGroup
    {

        ///<summary> 
        /// Creates a new ORM_O01_PATIENT_VISIT Group.
        ///</summary>
        public ORM_O01_PATIENT_VISIT(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(PV1), true, false);
                this.add(typeof(PV2), false, false);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORM_O01_PATIENT_VISIT - this is probably a bug in the source code generator.", e);
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
        /// Returns PV2 (PV2 - patient visit - additional information segment) - creates it if necessary
        ///</summary>
        public PV2 PV2
        {
            get
            {
                PV2 ret = null;
                try
                {
                    ret = (PV2)this.GetStructure("PV2");
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
