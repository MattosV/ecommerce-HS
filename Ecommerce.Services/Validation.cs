using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Ecommerce.Services
{
    public class Validation
    {

        public static bool CheckCpf(string vrCPF)
        {
            string CpfNumber = vrCPF.Replace(".", "");

            CpfNumber = CpfNumber.Replace("-", "");

            if (CpfNumber.Length != 11) return false;

            bool isEqual = true;

            for (int i = 1; i < 11 && isEqual; i++)
            {
                if (CpfNumber[i] != CpfNumber[0]) isEqual = false;
            }

            if (isEqual || CpfNumber == "12345678909") return false;

            int[] Numbers = new int[11];

            for (int i = 0; i < 11; i++)
            {
                Numbers[i] = int.Parse(CpfNumber[i].ToString());
            }              

            int Sum = 0;

            for (int i = 0; i < 9; i++)
            {
                Sum += (10 - i) * Numbers[i];
            }

            int Result = Sum % 11;

            if (Result == 1 || Result == 0)
            {
                if (Numbers[9] != 0) return false;
            }
            else if (Numbers[9] != 11 - Result) return false;

            Sum = 0;

            for (int i = 0; i < 10; i++)
            {
                Sum += (11 - i) * Numbers[i];
            }

            Result = Sum % 11;

            if (Result == 1 || Result == 0)
            {
                if (Numbers[10] != 0) return false;
            }
            else if (Numbers[10] != 11 - Result) return false;
            return true;
        }

        public static bool CheckEmail(string Email)
        {
            bool ValidEmail = false;
            int indexArr = Email.IndexOf("@");
            if (indexArr > 0)
            {
                if (Email.IndexOf("@", indexArr + 1) > 0)
                {
                    return ValidEmail;
                }

                int indexDot = Email.IndexOf(".", indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < Email.Length)
                    {
                        string indexDot2 = Email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            ValidEmail = true;
                        }
                    }
                }
            }
            return ValidEmail;
        }

        public Adress CheckCEP(string CEP)
        {
            HttpWebRequest Requisition = (HttpWebRequest)WebRequest.Create("http://www.buscacep.correios.com.br/servicos/dnec/consultaLogradouroAction.do? Metodo=listaLogradouro&CEP=" + CEP + "&TipoConsulta=cep");
            HttpWebResponse Response = (HttpWebResponse)Requisition.GetResponse();
            int cont;
            byte[] buffer = new byte[1000];
            StringBuilder sb = new StringBuilder();
            string temp;
            Stream stream = Response.GetResponseStream();
            do
            {
                cont = stream.Read(buffer, 0, buffer.Length);
                temp = Encoding.Default.GetString(buffer, 0, cont).Trim();
                sb.Append(temp);
            } while (cont > 0);
            string page = sb.ToString();
            if (page.IndexOf("<font color=\"black\">CEP NAO ENCONTRADO</font>") >= 0)
            {
                return null;
            }
            else {
                string street = Regex.Match(page, "<td width=\"268\" style=\"padding: 2px\">(.*)</td>").Groups[1].Value;
                string neighborhood = Regex.Matches(page, "<td width=\"140\" style=\"padding: 2px\">(.*)</td>")[0].Groups[1].Value;
                string city = Regex.Matches(page, "<td width=\"140\" style=\"padding: 2px\">(.*)</td>")[1].Groups[1].Value;
                string state = Regex.Match(page, "<td width=\"25\" style=\"padding: 2px\">(.*)</td>").Groups[1].Value;

                return new Adress(street, neighborhood, city, state);
            }
        }

        public static bool CheckBDate(DateTime Birthday) //Checks if the user is older than 16 and younger than 150 
        {
            DateTime DateToday = DateTime.Today;
            int Age = DateToday.Year - Birthday.Year;
            if (Birthday.Month > DateToday.Month) Age -= 1;
            if (Birthday.Month == DateToday.Month || Birthday.Day > DateToday.Day) Age -= 1;

            if (Age >= 16 || Age <= 150) return true;
            return false;
        }

    }
}
