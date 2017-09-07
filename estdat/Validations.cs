using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estdat
{   

    public class Validations
    {
        private static string Error;


        public bool DataType_Validation(string data, string type)
        {
            bool result = false;

            switch (type)
            {
                case "int":
                    int varInt = 0;
                    if (int.TryParse(data, out varInt))
                    {
                        result = true;
                    }
                    break;
                case "float":
                    float varFloat = 0;
                    if (float.TryParse(data, out varFloat))
                    {
                        result = true;
                    }
                    break;
                case "bool":
                    if (!(data == "TRUE" || data == "FALSE"))
                    {
                        if (bool.TryParse(data, out result))
                        {
                            result = true;
                        }
                    }                    
                    break;
                case "char":
                    char varChar = 'C';
                    if (char.TryParse(data, out varChar))
                    {
                        result = true;
                    }
                    break;
                case "object":
                    result = true;
                    break;

                case "ADT1":
                    break;
                case "ADT2":
                    break;
            }
            return result;
        }

        public string Get_Error()
        {
            return Error;
        }
    }
}
