using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Services
{
    static class VacationService
    {
        public static int CalculateVacationDays(DateTime startDate, DateTime endDate)
        {
            //https://www.dagmar-mueller.de/wdz/html/feiertagsberechnung.html
            //Ostersonntag - 48 Tage = Rosenmontag
            //Ostersonntag + 49 Tage = Pfingstsonntag
            //Pfingstsonntag - 10 Tage = Christi Himmelfahrt
            //Pfingstsonntag + 11 Tage = Fronleichnam

            int J = startDate.Year;
            int a = J % 19;
            int b = J % 4;
            int c = J % 7;
            int m = ((8 * (J / 100) + 13) / 25) - 2;
            int s = (J / 100) - (J / 400) - 2;
            int M = (15 + s - m) % 30;
            int N = (6 + s) % 7;
            int d = (M + 19 * a) % 30;

            return 0;
        }
    }
}
