using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllMarkirovka
{
    public class Class1
    {
        public int GetYear(string shifr)
        {
            try
            {
                string date = shifr[0].ToString() + shifr[1].ToString() + shifr[2].ToString() + shifr[3].ToString() + shifr[4].ToString() + shifr[5].ToString() + shifr[6].ToString() + shifr[7].ToString();
                if (int.TryParse(date, out var resul))
                {
                    date = shifr[0].ToString() + shifr[1].ToString() + "." + shifr[2].ToString() + shifr[3].ToString() + "." + shifr[4].ToString() + shifr[5].ToString() + shifr[6].ToString() + shifr[7].ToString();

                    DateTime dateTime = Convert.ToDateTime(date);
                    dateTime.ToString("dd.MM.yyyy");
                    return resul;

                }
                else
                    return 0;
            }
            catch
            {
                return 0;
            }
        }
        public string GetFirma(string shifr)
        {
            try
            {
                string firma = shifr[8].ToString() + shifr[9].ToString() + shifr[10].ToString();
                firma = firma.ToUpper();
                string result = "";
                switch (firma)
                {
                    case "RRR":
                        result = "фирма «Солнышко»";
                        break;
                    case "NNN":
                        result = "фирма «Утро»";
                        break;
                    case "JJJ":
                        result = "фирма «Улыбка»";
                        break;
                    case "FFF":
                        result = "фирма «Здоровье»";
                        break;
                    case "SSS":
                        result = "фирма «Дружба»";
                        break;
                    default:
                        result = "ошибка";
                        break;
                }
                return result;
            }
            catch
            {
                return "ошибка";
            }
        }

        public int GetNomer(string shifr)
        {
            try
            {
                string number = shifr[11].ToString() + shifr[12].ToString() + shifr[13].ToString();
                if (int.TryParse(number, out int result))
                    return result;
                else
                    return 0;
            }
            catch
            {
                return 0;
            }
        }
    }
}
