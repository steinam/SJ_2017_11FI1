using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using KalendarRoutines;




namespace UNitTest_for_CalendarRoutines
{

    [TestFixture] //TestKlasse
    public class TestCalendar
    {




        [Test]
        public void Test_DayOfWeek_Returns_Correct_Weekday()
        {

            //arrange
            //Variablen definieren
            //DB-Connectipon erzeugen

            //act


            //assert
            //Überprüfung von erwartetem und tatsächlichem Ergebnis
            Assert.AreEqual(20, Calendar.d_year(20, 1, 2017));
            Assert.AreEqual(61, Calendar.d_year(1, 3, 2016));
            Assert.AreEqual(365, Calendar.d_year(-1, 12, 2017));

        }

        
        [Test]
        public void Test_If_Day_Year_Throws_Exception_When_Negative_Day()
        {

            Assert.Throws<System.FormatException>(() => Calendar.d_year(-3, 12, 2017));
        }


    }
}
