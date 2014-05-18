using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript
{
    public abstract class Variables
    {
        public abstract string Name { get; set; }
        public abstract string Value { get; set; }
        public abstract string GetType();
    }

    /// <summary>
    /// Represents a 32-bit signed integer.
    /// </summary>
    class INT : Variables
    {
        public override string Name { get; set; }
        public override string Value { get; set; }

        /// <summary>
        /// Constructor INT
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public INT(string Name) 
        { 
            this.Name = Name;
            this.Value = string.Empty;
        }

        /// <summary>
        /// Constructor INT
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        public INT(string Name, string Value) 
        { 
            this.Name = Name; 
            this.Value = Value; 
        }

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
        public override string Name { get; set; }
        public override string Value { get; set; }

        public BOOL(string Name) 
        { 
            this.Name = Name;
            this.Value = string.Empty;
        }

        public BOOL(string Name, string Value) 
        { 
            this.Name = Name; 
            this.Value = Value; 
        }

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
        public override string Name { get; set; }
        public override string Value { get; set; }

        public DOUBLE(string Name)
        {
            this.Name = Name;
            this.Value = string.Empty;
        }

        public DOUBLE(string Name, string Value)
        {
            this.Name = Name;
            this.Value = Value;
        }

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
        public override string Name { get; set; }
        public override string Value { get; set; }

        public FLOAT(string Name)
        {
            this.Name = Name;
            this.Value = string.Empty;
        }

        public FLOAT(string Name, string Value)
        {
            this.Name = Name;
            this.Value = Value;
        }

        public override string GetType()
        {
            return "float";
        }
    }
}
