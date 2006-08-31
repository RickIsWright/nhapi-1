using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
    ///<summary>
    ///Represents the PPT_PCL_PROBLEM Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: PRB (Problem Detail) 
    /// * 1: NTE (NTE - notes and comments segment) optional repeating
    /// * 2: VAR (Variance) optional repeating
    /// * 3: PPT_PCL_PROBLEM_ROLE (a Group object) optional repeating
    /// * 4: PPT_PCL_PROBLEM_OBSERVATION (a Group object) optional repeating
    ///</summary>
    [Serializable]
    public class PPT_PCL_PROBLEM : AbstractGroup
    {

        ///<summary> 
        /// Creates a new PPT_PCL_PROBLEM Group.
        ///</summary>
        public PPT_PCL_PROBLEM(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(PRB), true, false);
                this.add(typeof(NTE), false, true);
                this.add(typeof(VAR), false, true);
                this.add(typeof(PPT_PCL_PROBLEM_ROLE), false, true);
                this.add(typeof(PPT_PCL_PROBLEM_OBSERVATION), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PPT_PCL_PROBLEM - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns PRB (Problem Detail) - creates it if necessary
        ///</summary>
        public PRB PRB
        {
            get
            {
                PRB ret = null;
                try
                {
                    ret = (PRB)this.GetStructure("PRB");
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
        /// Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary
        ///</summary>
        public NTE getNTE()
        {
            NTE ret = null;
            try
            {
                ret = (NTE)this.GetStructure("NTE");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of NTE
        /// * (NTE - notes and comments segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public NTE getNTE(int rep)
        {
            return (NTE)this.GetStructure("NTE", rep);
        }

        /** 
         * Returns the number of existing repetitions of NTE 
         */
        public int NTEReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("NTE").Length;
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
        /// Returns  first repetition of VAR (Variance) - creates it if necessary
        ///</summary>
        public VAR getVAR()
        {
            VAR ret = null;
            try
            {
                ret = (VAR)this.GetStructure("VAR");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of VAR
        /// * (Variance) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public VAR getVAR(int rep)
        {
            return (VAR)this.GetStructure("VAR", rep);
        }

        /** 
         * Returns the number of existing repetitions of VAR 
         */
        public int VARReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("VAR").Length;
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
        /// Returns  first repetition of PPT_PCL_PROBLEM_ROLE (a Group object) - creates it if necessary
        ///</summary>
        public PPT_PCL_PROBLEM_ROLE getPROBLEM_ROLE()
        {
            PPT_PCL_PROBLEM_ROLE ret = null;
            try
            {
                ret = (PPT_PCL_PROBLEM_ROLE)this.GetStructure("PROBLEM_ROLE");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of PPT_PCL_PROBLEM_ROLE
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public PPT_PCL_PROBLEM_ROLE getPROBLEM_ROLE(int rep)
        {
            return (PPT_PCL_PROBLEM_ROLE)this.GetStructure("PROBLEM_ROLE", rep);
        }

        /** 
         * Returns the number of existing repetitions of PPT_PCL_PROBLEM_ROLE 
         */
        public int PROBLEM_ROLEReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("PROBLEM_ROLE").Length;
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
        /// Returns  first repetition of PPT_PCL_PROBLEM_OBSERVATION (a Group object) - creates it if necessary
        ///</summary>
        public PPT_PCL_PROBLEM_OBSERVATION getPROBLEM_OBSERVATION()
        {
            PPT_PCL_PROBLEM_OBSERVATION ret = null;
            try
            {
                ret = (PPT_PCL_PROBLEM_OBSERVATION)this.GetStructure("PROBLEM_OBSERVATION");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of PPT_PCL_PROBLEM_OBSERVATION
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public PPT_PCL_PROBLEM_OBSERVATION getPROBLEM_OBSERVATION(int rep)
        {
            return (PPT_PCL_PROBLEM_OBSERVATION)this.GetStructure("PROBLEM_OBSERVATION", rep);
        }

        /** 
         * Returns the number of existing repetitions of PPT_PCL_PROBLEM_OBSERVATION 
         */
        public int PROBLEM_OBSERVATIONReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("PROBLEM_OBSERVATION").Length;
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
