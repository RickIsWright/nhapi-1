using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment
{

    ///<summary>
    /// Represents an HL7 URS message segment. 
    /// This segment has the following fields:
    /// * URS-1: R/U Where Subject Definition (ST)
    /// * URS-2: R/U When Data Start Date/Time (TS)
    /// * URS-3: R/U When Data End Date/Time (TS)
    /// * URS-4: R/U What User Qualifier (ST)
    /// * URS-5: R/U Other Results Subject Definition (ST)
    /// * URS-6: R/U Which Date/Time Qualifier (ID)
    /// * URS-7: R/U Which Date/Time Status Qualifier (ID)
    /// * URS-8: R/U Date/Time Selection Qualifier (ID)
    /// * URS-9: R/U Quantity/Timing Qualifier (TQ)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class URS : AbstractSegment
    {

        /**
         * Creates a URS (Unsolicited selection segment) segment object that belongs to the given 
         * message.  
         */
        public URS(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(ST), true, 0, 20, new System.Object[] { message }, "R/U Where Subject Definition");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "R/U When Data Start Date/Time");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "R/U When Data End Date/Time");
                this.add(typeof(ST), false, 0, 20, new System.Object[] { message }, "R/U What User Qualifier");
                this.add(typeof(ST), false, 0, 20, new System.Object[] { message }, "R/U Other Results Subject Definition");
                this.add(typeof(ID), false, 0, 12, new System.Object[] { message, 156 }, "R/U Which Date/Time Qualifier");
                this.add(typeof(ID), false, 0, 12, new System.Object[] { message, 157 }, "R/U Which Date/Time Status Qualifier");
                this.add(typeof(ID), false, 0, 12, new System.Object[] { message, 158 }, "R/U Date/Time Selection Qualifier");
                this.add(typeof(TQ), false, 1, 60, new System.Object[] { message }, "R/U Quantity/Timing Qualifier");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns a single repetition of R/U Where Subject Definition(URS-1).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getRUWhereSubjectDefinition(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(1, rep);
                ret = (ST)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of R/U Where Subject Definition (URS-1).
        ///</summary>
        public ST[] getRUWhereSubjectDefinition()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(1);
                ret = new ST[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ST)t[i];
                }
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                throw new System.Exception("An unexpected error ocurred", he);
            }
            catch (System.Exception cce)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
                throw new System.Exception("An unexpected error ocurred", cce);
            }
            return ret;
        }

        ///<summary>
        /// Returns R/U When Data Start Date/Time(URS-2).
        ///</summary>
        public TS RUWhenDataStartDateTime
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(2, 0);
                    ret = (TS)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns R/U When Data End Date/Time(URS-3).
        ///</summary>
        public TS RUWhenDataEndDateTime
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(3, 0);
                    ret = (TS)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns a single repetition of R/U What User Qualifier(URS-4).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getRUWhatUserQualifier(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(4, rep);
                ret = (ST)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of R/U What User Qualifier (URS-4).
        ///</summary>
        public ST[] getRUWhatUserQualifier()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(4);
                ret = new ST[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ST)t[i];
                }
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                throw new System.Exception("An unexpected error ocurred", he);
            }
            catch (System.Exception cce)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
                throw new System.Exception("An unexpected error ocurred", cce);
            }
            return ret;
        }

        ///<summary>
        /// Returns a single repetition of R/U Other Results Subject Definition(URS-5).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getRUOtherResultsSubjectDefinition(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(5, rep);
                ret = (ST)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of R/U Other Results Subject Definition (URS-5).
        ///</summary>
        public ST[] getRUOtherResultsSubjectDefinition()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(5);
                ret = new ST[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ST)t[i];
                }
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                throw new System.Exception("An unexpected error ocurred", he);
            }
            catch (System.Exception cce)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
                throw new System.Exception("An unexpected error ocurred", cce);
            }
            return ret;
        }

        ///<summary>
        /// Returns a single repetition of R/U Which Date/Time Qualifier(URS-6).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ID getRUWhichDateTimeQualifier(int rep)
        {
            ID ret = null;
            try
            {
                IType t = this.GetField(6, rep);
                ret = (ID)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of R/U Which Date/Time Qualifier (URS-6).
        ///</summary>
        public ID[] getRUWhichDateTimeQualifier()
        {
            ID[] ret = null;
            try
            {
                IType[] t = this.GetField(6);
                ret = new ID[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ID)t[i];
                }
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                throw new System.Exception("An unexpected error ocurred", he);
            }
            catch (System.Exception cce)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
                throw new System.Exception("An unexpected error ocurred", cce);
            }
            return ret;
        }

        ///<summary>
        /// Returns a single repetition of R/U Which Date/Time Status Qualifier(URS-7).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ID getRUWhichDateTimeStatusQualifier(int rep)
        {
            ID ret = null;
            try
            {
                IType t = this.GetField(7, rep);
                ret = (ID)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of R/U Which Date/Time Status Qualifier (URS-7).
        ///</summary>
        public ID[] getRUWhichDateTimeStatusQualifier()
        {
            ID[] ret = null;
            try
            {
                IType[] t = this.GetField(7);
                ret = new ID[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ID)t[i];
                }
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                throw new System.Exception("An unexpected error ocurred", he);
            }
            catch (System.Exception cce)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
                throw new System.Exception("An unexpected error ocurred", cce);
            }
            return ret;
        }

        ///<summary>
        /// Returns a single repetition of R/U Date/Time Selection Qualifier(URS-8).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ID getRUDateTimeSelectionQualifier(int rep)
        {
            ID ret = null;
            try
            {
                IType t = this.GetField(8, rep);
                ret = (ID)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of R/U Date/Time Selection Qualifier (URS-8).
        ///</summary>
        public ID[] getRUDateTimeSelectionQualifier()
        {
            ID[] ret = null;
            try
            {
                IType[] t = this.GetField(8);
                ret = new ID[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ID)t[i];
                }
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                throw new System.Exception("An unexpected error ocurred", he);
            }
            catch (System.Exception cce)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
                throw new System.Exception("An unexpected error ocurred", cce);
            }
            return ret;
        }

        ///<summary>
        /// Returns R/U Quantity/Timing Qualifier(URS-9).
        ///</summary>
        public TQ RUQuantityTimingQualifier
        {
            get
            {
                TQ ret = null;
                try
                {
                    IType t = this.GetField(9, 0);
                    ret = (TQ)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }


    }
}