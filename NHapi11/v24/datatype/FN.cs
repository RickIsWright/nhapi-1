using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v24.datatype
{

///<summary>
/// <p>The HL7 FN (familiy name) data type.  Consists of the following components: </p><ol>
/// <li>surname (ST)</li>
/// <li>own surname prefix (ST)</li>
/// <li>own surname (ST)</li>
/// <li>surname prefix from partner/spouse (ST)</li>
/// <li>surname from partner/spouse (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class FN : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a FN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public FN(Message message) : this(message, null){}

	///<summary>
	/// Creates a FN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public FN(Message message, string description) : base(message, description){
		data = new Type[5];
		data[0] = new ST(message,"Surname");
		data[1] = new ST(message,"Own surname prefix");
		data[2] = new ST(message,"Own surname");
		data[3] = new ST(message,"Surname prefix from partner/spouse");
		data[4] = new ST(message,"Surname from partner/spouse");
	}

	///<summary>
	/// Returns an array containing the data elements.
	///</summary>
	public Type[] Components
	{ 
		get{
			return this.data; 
		}
	}

	///<summary>
	/// Returns an individual data component.
	/// @throws DataTypeException if the given element number is out of range.
	///<param name="number">The ordinal item to get</param>
	///<returns>The data component (as a type) at the requested number (ordinal)</returns>
	///<summary>
	public Type getComponent(int number) { 

		try { 
			return this.data[number]; 
		} catch (System.ArgumentOutOfRangeException) { 
			throw new DataTypeException("Element " + number + " doesn't exist in 5 element FN composite"); 
		} 
	} 
	///<summary>
	/// Returns surname (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST Surname {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns own surname prefix (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST OwnSurnamePrefix {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns own surname (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST OwnSurname {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns surname prefix from partner/spouse (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST SurnamePrefixFromPartnerSpouse {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns surname from partner/spouse (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST SurnameFromPartnerSpouse {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(4);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}