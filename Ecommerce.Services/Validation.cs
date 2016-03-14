

using System;

namespace Ecommerce.Services
{
    public class Validation
    {

        public static bool CheckCpf(string vrCPF) //Check if CPF is valid
        {
            //Check if the CPF saved has special characters and remove them
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
