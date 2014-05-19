using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript
{
    /// <summary>
    /// Class abstract for Variables.
    /// </summary>
    public abstract class Variables
    {
        /// <summary>
        /// Abstract string Name.
        /// </summary>
        public abstract string Name { get; set; }
        /// <summary>
        /// Abstract string Value.
        /// </summary>
        public abstract string Value { get; set; }
        /// <summary>
        /// Abstract string type of variables.
        /// </summary>
        /// <returns>String type.</returns>
        public abstract string GetType();
    }

    /// <summary>
    /// Represents a 32-bit signed integer.
    /// </summary>
    class INT : Variables
    {
        /// <summary>
        /// String name of Variables.
        /// </summary>
        public override string Name { get; set; }
        /// <summary>
        /// String value of Variables.
        /// </summary>
        public override string Value { get; set; }

        /// <summary>
        /// Constructor INT
        /// </summary>
        /// <param name="Name">Name for Variables</param>
        public INT(string Name) 
        { 
            this.Name = Name;
            this.Value = string.Empty;
        }

        /// <summary>
        /// Constructor INT
        /// </summary>
        /// <param name="Name">Name for Variables</param>
        /// <param name="Value">Value for Variables</param>
        public INT(string Name, string Value) 
        { 
            this.Name = Name; 
            this.Value = Value; 
        }

        /// <summary>
        /// Type of Variables.
        /// </summary>
        /// <returns>String type.</returns>
        public override string GetType()
        {
            return "int";
        }
    }

    /// <summary>
    /// Represents a Boolean value.
    /// </summary>
    public class BOOL : Variables
    {
        /// <summary>
        /// String name of Variables.
        /// </summary>
        public override string Name { get; set; }
        /// <summary>
        /// String value of Variables.
        /// </summary>
        public override string Value { get; set; }

        /// <summary>
        /// Constructor BOOL
        /// </summary>
        /// <param name="Name">Name for Variables</param>
        public BOOL(string Name) 
        { 
            this.Name = Name;
            this.Value = string.Empty;
        }

        /// <summary>
        /// Constructor DOUBLE
        /// </summary>
        /// <param name="Name">Name for Variables</param>
        /// <param name="Value">Value for Variables</param>
        public BOOL(string Name, string Value) 
        { 
            this.Name = Name; 
            this.Value = Value; 
        }

        /// <summary>
        /// Type of Variables.
        /// </summary>
        /// <returns>String type.</returns>
        public override string GetType()
        {
            return "bool";
        }
    }

    /// <summary>
    /// Represents a double-precision floating-point number.
    /// </summary>
    public class DOUBLE : Variables
    {
        /// <summary>
        /// String name of Variables.
        /// </summary>
        public override string Name { get; set; }
        /// <summary>
        /// String value of Variables.
        /// </summary>
        public override string Value { get; set; }

        /// <summary>
        /// Constructor DOUBLE
        /// </summary>
        /// <param name="Name">Name for Variables</param>
        public DOUBLE(string Name) 
        { 
            this.Name = Name;
            this.Value = string.Empty;
        }

        /// <summary>
        /// Constructor DOUBLE
        /// </summary>
        /// <param name="Name">Name for Variables</param>
        /// <param name="Value">Value for Variables</param>
        public DOUBLE(string Name, string Value) 
        { 
            this.Name = Name; 
            this.Value = Value; 
        }

        /// <summary>
        /// Type of Variables.
        /// </summary>
        /// <returns>String type.</returns>
        public override string GetType()
        {
            return "double";
        }
    }

    /// <summary>
    /// Represents a single-precision floating-point number.
    /// </summary>
    public class FLOAT : Variables
    {
        /// <summary>
        /// String name of Variables.
        /// </summary>
        public override string Name { get; set; }
        /// <summary>
        /// String value of Variables.
        /// </summary>
        public override string Value { get; set; }

        /// <summary>
        /// Constructor FLOAT
        /// </summary>
        /// <param name="Name">Name for Variables</param>
        public FLOAT(string Name) 
        { 
            this.Name = Name;
            this.Value = string.Empty;
        }

        /// <summary>
        /// Constructor FLOAT
        /// </summary>
        /// <param name="Name">Name for Variables</param>
        /// <param name="Value">Value for Variables</param>
        public FLOAT(string Name, string Value) 
        { 
            this.Name = Name; 
            this.Value = Value; 
        }

        /// <summary>
        /// Type of Variables.
        /// </summary>
        /// <returns>String type.</returns>
        public override string GetType()
        {
            return "float";
        }
    }
}
