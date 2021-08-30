using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace grafik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Schedule
    {
        public static void Date()
        {
            Calendar myCal = new GregorianCalendar();
            int iYear, iMonth, iDay;
            DateTime myDT = DateTime.Today;
            
            iYear = myCal.GetYear(myDT);
            Console.WriteLine("Rok: {1}", myCal.GetType(), myCal.GetYear(myDT));
            Console.WriteLine( "Liczba miesiecy: {0}", myCal.GetMonthsInYear(iYear));
            Console.WriteLine( "Dni w kazdym z miesiecy:" );
            for (int j = 1; j <= myCal.GetMonthsInYear(iYear); j++ )
                Console.Write( " {0,-5}", myCal.GetDaysInMonth(iYear,j ) );
            Console.WriteLine();
        }
        public void MetaData() {
            int NumberOfSoldiers = 4;
            
        }
    }
}


#include <stdio.h>

int main() {

    int workDays[4];
    int days[]={0,31,28,31,30,31,30,31,31,30,31,30,31};
    char *months[]= {
        " ",
        "Styczen",
        "Luty",
        "Marzec",
        "Kwiecien",
        "Maj",
        "Czerwiec",
        "Lipiec",
        "Sierpien",
        "Wrzesien",
        "Pazdziernik",
        "Listopad",
        "Grudzien"
    };

    int numberOfSoldiers = 4;
    char *soldiers[] = {
        {"Mamla"},
        {"Karol"},
        {"Roman"},
        {"Hitler"},
    };
    for(int i=0; i<numberOfSoldiers; ++i) {
        printf("Ile dni pracuje %s?\n", soldiers[i]);
        scanf("%d", &workDays[i]);
    }

    for(int i=0; i<numberOfSoldiers; ++i) {
        int grafik[4];

        printf("W jakie dni pracuje %s?\n", soldiers[i]);
        for (int j = 0; j < workDays[i]; ++j) {
            scanf("%d", &grafik[i]);
        }
    }

    for(int i=0; i<numberOfSoldiers; ++i) {
        printf("%s.\n", soldiers[i]);
        for (int k = 1; k <= days[k]; ++k) {
            if (days[k] == grafik[i]) {
                printf("%d. ");
            }
        }
    }
};

