using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v231.datatype
{

///<summary>
/// <p>The HL7 FC (financial class) data type.  Consists of the following components: </p><ol>
/// <li>Financial Class (IS)</li>
/// <li>Effective Date (TS)</li>
/// </ol>
///</summary>
[Serializable]
public class FC : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a FC.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public FC(Message message) : this(message, null){}

	///<summary>
	/// Creates a FC.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public FC(Message message, string description) : base(message, description){
		data = new Type[2];
		data[0] = new IS(message, 64,"Financial Class");
		data[1] = new TS(message,"Effective Date");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element FC composite"); 
		} 
	} 
	///<summary>
	/// Returns Financial Class (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS FinancialClass {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Effective Date (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TS EffectiveDate {
get{
	   TS ret = null;
	   try {
	      ret = (TS)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}