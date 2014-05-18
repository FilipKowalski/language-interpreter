using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretScript.parser
{
    class ParserVariables
    {
        List<Variables> ListVariables { get; set; }
        public ParserVariables(List<Variables> ListVariables)
        {
            this.ListVariables = ListVariables;
        }

        public void Parsing(string input)
        {
            string Type = string.Empty;
            int index = -1;
            if(input.IndexOf("int ", 0) != -1)
            {
                index = input.IndexOf("int ", 0) + 3;
                Type = "int";
            }
            else if(input.IndexOf("bool ", 0) != -1)
            {
                index = input.IndexOf("bool", 0) + 4;
                Type = "bool";
            }
            else if(input.IndexOf("float ", 0) != -1)
            {
                index = input.IndexOf("float", 0) + 5;
                Type = "float";
            }
            else if(input.IndexOf("double ", 0) != -1)
            {
                index = input.IndexOf("double", 0) + 6;
                Type = "double";
            }
            if(index != -1)
            {
                string name = string.Empty;
                string value = string.Empty;

                // Szukanie do kiedy spacja
                while (index < input.Length)
                {
                    if (input[index] == (char)32)
                        index++;
                    else
                        break;
                }

                // Pobranie nazwy zmiennej
                while (index < input.Length)
                {
                    if (input[index] == ' ' || input[index] == '=')
                        break;
                    name += input[index++];
                }

                index = input.IndexOf("=", index);
                if (index != -1)
                {
                    index++;
                    value = input.Substring(index).Replace(" ", "");
                    if(Type == "bool")
                    {
                        if (value.IndexOf("true") != -1)
                            value = "1";
                        else
                            value = "0";
                    }
                }
                else
                {
                    value = "0";
                }

                switch(Type)
                {
                    case "int": ListVariables.Add(new INT(name, value)); break;
                    case "bool": ListVariables.Add(new BOOL(name, value)); break;
                    case "float": ListVariables.Add(new FLOAT(name, value)); break;
                    case "double": ListVariables.Add(new DOUBLE(name, value)); break;
                }
            }
        }
    }
}
