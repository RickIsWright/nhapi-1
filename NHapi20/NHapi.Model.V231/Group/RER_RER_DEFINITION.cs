using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
    ///<summary>
    ///Represents the RER_RER_DEFINITION Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: QRD (QRD - original-style query definition segment) 
    /// * 1: QRF (QRF - original style query filter segment) optional 
    /// * 2: RER_RER_PATIENT (a Group object) optional 
    /// * 3: RER_RER_ORDER (a Group object) repeating
    ///</summary>
    [Serializable]
    public class RER_RER_DEFINITION : AbstractGroup
    {

        ///<summary> 
        /// Creates a new RER_RER_DEFINITION Group.
        ///</summary>
        public RER_RER_DEFINITION(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(QRD), true, false);
                this.add(typeof(QRF), false, false);
                this.add(typeof(RER_RER_PATIENT), false, false);
                this.add(typeof(RER_RER_ORDER), true, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RER_RER_DEFINITION - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns QRD (QRD - original-style query definition segment) - creates it if necessary
        ///</summary>
        public QRD QRD
        {
            get
            {
                QRD ret = null;
                try
                {
                    ret = (QRD)this.GetStructure("QRD");
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
        /// Returns QRF (QRF - original style query filter segment) - creates it if necessary
        ///</summary>
        public QRF QRF
        {
            get
            {
                QRF ret = null;
                try
                {
                    ret = (QRF)this.GetStructure("QRF");
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
        /// Returns RER_RER_PATIENT (a Group object) - creates it if necessary
        ///</summary>
        public RER_RER_PATIENT PATIENT
        {
            get
            {
                RER_RER_PATIENT ret = null;
                try
                {
                    ret = (RER_RER_PATIENT)this.GetStructure("PATIENT");
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
        /// Returns  first repetition of RER_RER_ORDER (a Group object) - creates it if necessary
        ///</summary>
        public RER_RER_ORDER getORDER()
        {
            RER_RER_ORDER ret = null;
            try
            {
                ret = (RER_RER_ORDER)this.GetStructure("ORDER");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of RER_RER_ORDER
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public RER_RER_ORDER getORDER(int rep)
        {
            return (RER_RER_ORDER)this.GetStructure("ORDER", rep);
        }

        /** 
         * Returns the number of existing repetitions of RER_RER_ORDER 
         */
        public int ORDERReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("ORDER").Length;
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