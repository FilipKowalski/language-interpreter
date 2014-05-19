using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript.parser
{
    class ParserTest
    {
        public ParserTest()
        {

        }

        public bool CheckFunctionFor(string value)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"for\([A-Za-z]+=[0-9]+; [A-Za-z][<>][0-9]+; [A-Za-z]+[\+\-][\+\-]\)"))
                return true;
            else
                return false;
        }

        public string GetFirstAttributeFor(string value)
        {
            value = value.Replace("\r", "");
            value = value.Replace(" ", "");
            System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(value.Substring(0), @"=[0-9]+;");
            return result.Groups[0].Value.Substring(1, result.Length - 2);
        }

        public bool GetLessAttributeFor(string value)
        {
            value = value.Replace("\r", "");
            value = value.Replace(" ", "");
            if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"<[0-9]+;"))
                return true;
            else
                return false;
        }

        public string GetSecondAttributeFor(string value)
        {
            value = value.Replace("\r", "");
            value = value.Replace(" ", "");
            System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(value.Substring(0), @"[<>][0-9]+;");
            return result.Groups[0].Value.Substring(1, result.Length - 2);
        }

        public string GetThirdAttribute(string value)
        {
            value = value.Replace("\r", "");
            value = value.Replace(" ", "");
            System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(value.Substring(0), @"[\+\-][\+\-]\)");
            return result.Groups[0].Value.Substring(0, result.Length - 2);
        }

        public string GetSourceFor(string value)
        {
            System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(value.Substring(0), @"{.*}");
            return result.Groups[0].Value.Substring(1, result.Length - 2);
        }

        public bool CheckPrintText(string value)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"print[ ]*\( *"+(char)34+@".+"+(char)34+@" *\)"))
                return true;
            else
                return false;
        }

        public string GetPrintText(string value)
        {
            System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(value.Substring(0), (char)34+@".+"+(char)34);
            return result.Groups[0].Value.Substring(1, result.Length-2);
        }

        public bool CheckPrintlText(string value)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"printl[ ]*\( *" + (char)34 + @".+" + (char)34 + @" *\)"))
                return true;
            else
                return false;
        }

        public string GetPrintlText(string value)
        {
            System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(value.Substring(0), (char)34 + @".+" + (char)34);
            return result.Groups[0].Value.Substring(1, result.Length - 2)+"\n";
        }

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

        public string GetCreateVariable(string value)
        {
            return value.Substring(0, value.Length - 1);
        }

        public bool CheckPrintVariables(string value)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"print[ ]*\(.+\)"))
                return true;
            else
                return false;
        }

        public string GetPrintVariables(string value)
        {
            value = value.Replace("\r", "");
            value = value.Replace(" ", "");
            System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(value.Substring(0), @"\(.+\)");
            return result.Groups[0].Value.Substring(1, result.Length - 2);
        }

        public bool CheckPrintlVariables(string value)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"printl[ ]*\(.+\)"))
                return true;
            else
                return false;
        }

        public bool CheckAttributeVariable(string value)
        {
            value = value.Replace("\r", "");
            value = value.Replace(" ", "");
            if (System.Text.RegularExpressions.Regex.IsMatch(value.Substring(0), @"[A-Za-z].*=.+"))
                return true;
            else
                return false;
        }

        public string GetAttributeVariable(string value)
        {
            value = value.Replace("\r", "");
            value = value.Replace(" ", "");
            return value.Substring(0, value.Length - 1);
        }

        public string GetNameVariable(string value)
        {
            value = value.Replace("\r", "");
            value = value.Replace(" ", "");

            System.Text.RegularExpressions.Match result = System.Text.RegularExpressions.Regex.Match(value.Substring(0), @"[A-Za-z]=");
            return result.Groups[0].Value.Substring(0, result.Length-1);
        }
    }
}
