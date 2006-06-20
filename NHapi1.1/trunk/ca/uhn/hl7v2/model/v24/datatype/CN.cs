using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v24.datatype
{

	///<summary>
	/// <p>The HL7 CN (composite ID number and name) data type.  Consists of the following components: </p><ol>
	/// <li>ID number (ST) (ST)</li>
	/// <li>family name (FN)</li>
	/// <li>given name (ST)</li>
	/// <li>second and further given names or initials thereof (ST)</li>
	/// <li>suffix (e.g., JR or III) (ST)</li>
	/// <li>prefix (e.g., DR) (ST)</li>
	/// <li>degree (e.g., MD) (IS)</li>
	/// <li>source table (IS)</li>
	/// <li>assigning authority (HD)</li>
	/// </ol>
	///</summary>
	public class CN : AbstractType, Composite
	{
		private Type[] data;

		///<summary>
		/// Creates a CN.
		/// <param name="message">The Message to which this Type belongs</param>
		///</summary>
		public CN(Message message) : base(message)
		{
			data = new Type[9];
			data[0] = new ST(message);
			data[1] = new FN(message);
			data[2] = new ST(message);
			data[3] = new ST(message);
			data[4] = new ST(message);
			data[5] = new ST(message);
			data[6] = new IS(message, 0);
			data[7] = new IS(message, 0);
			data[8] = new HD(message);
		}

		///<summary>
		/// Returns an array containing the data elements.
		///</summary>
		public Type[] Components
		{ 
			get
			{
				return this.data; 
			}
		}

		///<summary>
		/// Returns an individual data component.
		/// @throws DataTypeException if the given element number is out of range.
		///<param name="number">The ordinal item to get</param>
		///<returns>The data component (as a type) at the requested number (ordinal)</returns>
		///<summary>
		public Type getComponent(int number) 
		{ 

			try 
			{ 
				return this.data[number]; 
			} 
			catch (System.ArgumentOutOfRangeException) 
			{ 
				throw new DataTypeException("Element " + number + " doesn't exist in 9 element CN composite"); 
			} 
		} 
		///<summary>
		/// Returns ID number (ST) (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST IDNumber 
		{
			get
			{
				ST ret = null;
				try 
				{
					ret = (ST)getComponent(0);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns family name (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public FN FamilyName 
		{
			get
			{
				FN ret = null;
				try 
				{
					ret = (FN)getComponent(1);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns given name (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST GivenName 
		{
			get
			{
				ST ret = null;
				try 
				{
					ret = (ST)getComponent(2);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns second and further given names or initials thereof (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST SecondAndFurtherGivenNamesOrInitialsThereof 
		{
			get
			{
				ST ret = null;
				try 
				{
					ret = (ST)getComponent(3);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns suffix (e.g., JR or III) (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST SuffixEgJRorIII 
		{
			get
			{
				ST ret = null;
				try 
				{
					ret = (ST)getComponent(4);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns prefix (e.g., DR) (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST PrefixEgDR 
		{
			get
			{
				ST ret = null;
				try 
				{
					ret = (ST)getComponent(5);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns degree (e.g., MD) (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS DegreeEgMD 
		{
			get
			{
				IS ret = null;
				try 
				{
					ret = (IS)getComponent(6);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns source table (component #7).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS SourceTable 
		{
			get
			{
				IS ret = null;
				try 
				{
					ret = (IS)getComponent(7);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns assigning authority (component #8).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public HD AssigningAuthority 
		{
			get
			{
				HD ret = null;
				try 
				{
					ret = (HD)getComponent(8);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
	}}