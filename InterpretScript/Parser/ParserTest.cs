using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript.parser
{
    /// <summary>
    /// Class Parser Code for test with code.
    /// </summary>
    class ParserTest
    {
        /// <summary>
        /// Constructor ParserTest
        /// </summary>
        public ParserTest()
        {

        }

        /// <summary>
        /// Check function for.
        /// </summary>
        /// <param name="value">String for test.</param>
        /// <returns>Value boolean if it's correct.</returns>
        public bool CheckFunctionFor(string value)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"for\([A-Za-z]+=[0-9]+; [A-Za-z][<>][0-9]+; [A-Za-z]+[\+\-][\+\-]\)"))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Get first attribute for.
        /// </summary>
        /// <param name="value">String for looking for attribute.</param>
        /// <returns>String value attribute.</returns>
        public string GetFirstAttributeFor(string value)
        {
            value = value.Replace("\r", "");
            value = value.Replace(" ", "");
            System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(value.Substring(0), @"=[0-9]+;");
            return result.Groups[0].Value.Substring(1, result.Length - 2);
        }

        /// <summary>
        /// Get parameter control attribute for.
        /// </summary>
        /// <param name="value">String for looking for attribute.</param>
        /// <returns>Boolean value attribute.</returns>
        public bool GetLessAttributeFor(string value)
        {
            value = value.Replace("\r", "");
            value = value.Replace(" ", "");
            if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"<[0-9]+;"))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Get second attribute for.
        /// </summary>
        /// <param name="value">String for looking for attribute.</param>
        /// <returns>String value attribute.</returns>
        public string GetSecondAttributeFor(string value)
        {
            value = value.Replace("\r", "");
            value = value.Replace(" ", "");
            System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(value.Substring(0), @"[<>][0-9]+;");
            return result.Groups[0].Value.Substring(1, result.Length - 2);
        }

        /// <summary>
        /// Get third attribute for.
        /// </summary>
        /// <param name="value">String for looking for attribute.</param>
        /// <returns>String value attribute.</returns>
        public string GetThirdAttribute(string value)
        {
            value = value.Replace("\r", "");
            value = value.Replace(" ", "");
            System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(value.Substring(0), @"[\+\-][\+\-]\)");
            return result.Groups[0].Value.Substring(0, result.Length - 2);
        }

        /// <summary>
        /// Get source code attribute for.
        /// </summary>
        /// <param name="value">String for looking for attribute.</param>
        /// <returns>String value attribute.</returns>
        public string GetSourceFor(string value)
        {
            value = value.Replace("\r", "");
            value = value.Replace("\n", "");
            System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(value.Substring(0), @"{.*}");
            return result.Groups[0].Value.Substring(1, result.Length - 2);
        }

        /// <summary>
        /// Check function print.
        /// </summary>
        /// <param name="value">String for test.</param>
        /// <returns>Value boolean if it's correct.</returns>
        public bool CheckPrintText(string value)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"print[ ]*\( *"+(char)34+@".+"+(char)34+@" *\)"))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Get text to show without new line.
        /// </summary>
        /// <param name="value">String for looking for attribute.</param>
        /// <returns>String value attribute.</returns>
        public string GetPrintText(string value)
        {
            System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(value.Substring(0), (char)34+@".+"+(char)34);
            return result.Groups[0].Value.Substring(1, result.Length-2);
        }

        /// <summary>
        /// Check function printl.
        /// </summary>
        /// <param name="value">String for test.</param>
        /// <returns>Value boolean if it's correct.</returns>
        public bool CheckPrintlText(string value)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"printl[ ]*\( *" + (char)34 + @".+" + (char)34 + @" *\)"))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Get text to show with new line.
        /// </summary>
        /// <param name="value">String for looking for attribute.</param>
        /// <returns>String value attribute.</returns>
        public string GetPrintlText(string value)
        {
            System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(value.Substring(0), (char)34 + @".+" + (char)34);
            return result.Groups[0].Value.Substring(1, result.Length - 2)+"\n";
        }

        /// <summary>
        /// Check function create variable.
        /// </summary>
        /// <param name="value">String for test.</param>
        /// <returns>Value boolean if it's correct.</returns>
        public bool CheckCreateVariable(string value)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"int .+"))
                return true;
            else if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"bool .+"))
                return true;
            else if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"float .+"))
                return true;
            else if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"double .+"))
                return true;
            return false;
        }

        /// <summary>
        /// Get string to make a new variable.
        /// </summary>
        /// <param name="value">String for looking for attribute.</param>
        /// <returns>String value attribute.</returns>
        public string GetCreateVariable(string value)
        {
            return value.Substring(0, value.Length - 1);
        }

        /// <summary>
        /// Check function print variable.
        /// </summary>
        /// <param name="value">String for test.</param>
        /// <returns>Value boolean if it's correct.</returns>
        public bool CheckPrintVariables(string value)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"print[ ]*\(.+\)"))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Get text of variable to show without new line.
        /// </summary>
        /// <param name="value">String for looking for attribute.</param>
        /// <returns>String value attribute.</returns>
        public string GetPrintVariables(string value)
        {
            value = value.Replace("\r", "");
            value = value.Replace(" ", "");
            System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(value.Substring(0), @"\(.+\)");
            return result.Groups[0].Value.Substring(1, result.Length - 2);
        }

        /// <summary>
        /// Check function printl variable.
        /// </summary>
        /// <param name="value">String for test.</param>
        /// <returns>Value boolean if it's correct.</returns>
        public bool CheckPrintlVariables(string value)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"printl[ ]*\(.+\)"))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Check attribute variable.
        /// </summary>
        /// <param name="value">String for test.</param>
        /// <returns>Value boolean if it's correct.</returns>
        public bool CheckAttributeVariable(string value)
        {
            value = value.Replace("\r", "");
            value = value.Replace(" ", "");
            if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"[A-Za-z].*=.+"))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Get attribute of variable.
        /// </summary>
        /// <param name="value">String for looking for attribute.</param>
        /// <returns>String value attribute.</returns>
        public string GetAttributeVariable(string value)
        {
            value = value.Replace("\r", "");
            value = value.Replace(" ", "");
            return value.Substring(0, value.Length - 1);
        }

        /// <summary>
        /// Get name of variable.
        /// </summary>
        /// <param name="value">String for looking for attribute.</param>
        /// <returns>String value attribute.</returns>
        public string GetNameVariable(string value)
        {
            value = value.Replace("\r", "");
            value = value.Replace(" ", "");

            System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(value.Substring(0), @"[A-Za-z]=");
            return result.Groups[0].Value.Substring(0, result.Length-1);
        }
    }
}
