using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tkocz_KalkulatorBMI_ProjektowanieUI
{
    static class CalculateBMIModel
    {

        public static bool CheckValue(string valueIn, ref double doubleValue)
        {
            
            string valueToCheck=string.Empty;
            if (valueIn.Equals("0"))
            {
                return false;
            }
            if (valueIn.Contains('.'))
            {
                 valueToCheck=valueIn.Replace('.', ',');
            }
            if (!valueIn.Contains('.'))
            {
                valueToCheck = valueIn;
            }
            return Double.TryParse(valueToCheck, out doubleValue);
        }

        public static string GetResult(string height, string weight)
        {
            double doubleHeight = 0;
            double doubleWeight = 0;
            bool isHeightCorrect = CalculateBMIModel.CheckValue(height, ref doubleHeight);
            bool isWeightCorrect = CalculateBMIModel.CheckValue(weight, ref doubleWeight);
            double calculationHeight = (doubleHeight / 100);
            double BMI=0;
            if (isWeightCorrect == true && isHeightCorrect == true)
            {
                BMI = (doubleWeight / (calculationHeight * calculationHeight));
                return $"Twoje BMI wynosi {Math.Round(BMI, 1)}\n" + GetString(BMI);
            }
            if (isHeightCorrect==true && isWeightCorrect==false)
            {
                return "Podano nieprawidłową wagę";
            }
            if (isHeightCorrect==false&&isWeightCorrect==true)
            {
                return "Podano nieprawidłowy wzrost";
            }
            return "Podano nieprawidłową wagę i wzrost";

        }
        public static string GetString(double BMI)
        {
            if (BMI<16)
            {
                return "Twoje BMI wskazuje na wygłodzenie";
            }
            if (BMI>=16&&BMI<=17)
            {
                return "Twoje BMI wskazuje na wychudzenie";
            }
            if (BMI >= 17 && BMI < 18.5)
            {
                return "Twoje BMI wskazuje na niedowagę";
            }
            if (BMI >= 18.5 && BMI < 25)
            {
                return "Twoje BMI jest prawidłowe";
            }
            if (BMI >= 25 && BMI < 30)
            {
                return "Twoje BMI wskazuje na nadwagę";
            }
            if (BMI >= 30 && BMI < 35)
            {
                return "Twoje BMI wskazuje na otyłość I stopnia";
            }
            if (BMI >= 35 && BMI < 40)
            {
                return "Twoje BMI wskazuje na otyłość II stopnia";
            }
            if (BMI >= 40 )
            {
                return "Twoje BMI wskazuje na otyłość III stopnia";
            }
            return "Wartość nieprawidłowa";
        }
    }


}
