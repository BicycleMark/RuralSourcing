using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace Quorum
{
    public class Solution1
    {
        public int Solution()
        {

            return -1;
        }
        /*
                     string[] formats = {"d",
                                        "D", 
                                        "f", 
                                        "F", 
                                        "g", 
                                        "G", 
                                        "m", 
                                        "o", 
                                        "r",
                                        "s", 
                                        "t", 
                                        "T", 
                                        "u", 
                                        "U", 
                                        "Y"};
                    // Create an array of four cultures.
                    CultureInfo[] cultures = {CultureInfo.CreateSpecificCulture("de-DE"),
                                        CultureInfo.CreateSpecificCulture("en-US"),
                                        CultureInfo.CreateSpecificCulture("es-ES"),
                                        CultureInfo.CreateSpecificCulture("fr-FR")};
                    // Define date to be displayed.
                    DateTime dateToDisplay = new DateTime(2008, 10, 1, 17, 4, 32);

                    // Iterate each standard format specifier.
                    foreach (string formatSpecifier in formats)
                    {
                        foreach (CultureInfo culture in cultures)
                            Console.WriteLine("{0} Format Specifier {1, 10} Culture {2, 40}",
                                              formatSpecifier, culture.Name,
                                              dateToDisplay.ToString(formatSpecifier, culture));
                        Console.WriteLine();
                    }
                 // The example displays the following output:
        //    d Format Specifier      de-DE Culture                               01.10.2008
        //    d Format Specifier      en-US Culture                                10/1/2008
        //    d Format Specifier      es-ES Culture                               01/10/2008
        //    d Format Specifier      fr-FR Culture                               01/10/2008
        //
        //    D Format Specifier      de-DE Culture                Mittwoch, 1. Oktober 2008
        //    D Format Specifier      en-US Culture              Wednesday, October 01, 2008
        //    D Format Specifier      es-ES Culture         miércoles, 01 de octubre de 2008
        //    D Format Specifier      fr-FR Culture                  mercredi 1 octobre 2008
        //
        //    f Format Specifier      de-DE Culture          Mittwoch, 1. Oktober 2008 17:04
        //    f Format Specifier      en-US Culture      Wednesday, October 01, 2008 5:04 PM
        //    f Format Specifier      es-ES Culture   miércoles, 01 de octubre de 2008 17:04
        //    f Format Specifier      fr-FR Culture            mercredi 1 octobre 2008 17:04
        //
        //    F Format Specifier      de-DE Culture       Mittwoch, 1. Oktober 2008 17:04:32
        //    F Format Specifier      en-US Culture   Wednesday, October 01, 2008 5:04:32 PM
        //    F Format Specifier      es-ES Culture miércoles, 01 de octubre de 2008 17:04:3
        //    F Format Specifier      fr-FR Culture         mercredi 1 octobre 2008 17:04:32
        //
        //    g Format Specifier      de-DE Culture                         01.10.2008 17:04
        //    g Format Specifier      en-US Culture                        10/1/2008 5:04 PM
        //    g Format Specifier      es-ES Culture                         01/10/2008 17:04
        //    g Format Specifier      fr-FR Culture                         01/10/2008 17:04
        //
        //    G Format Specifier      de-DE Culture                      01.10.2008 17:04:32
        //    G Format Specifier      en-US Culture                     10/1/2008 5:04:32 PM
        //    G Format Specifier      es-ES Culture                      01/10/2008 17:04:32
        //    G Format Specifier      fr-FR Culture                      01/10/2008 17:04:32
        //
        //    m Format Specifier      de-DE Culture                               01 Oktober
        //    m Format Specifier      en-US Culture                               October 01
        //    m Format Specifier      es-ES Culture                               01 octubre
        //    m Format Specifier      fr-FR Culture                                1 octobre
        //
        //    o Format Specifier      de-DE Culture              2008-10-01T17:04:32.0000000
        //    o Format Specifier      en-US Culture              2008-10-01T17:04:32.0000000
        //    o Format Specifier      es-ES Culture              2008-10-01T17:04:32.0000000
        //    o Format Specifier      fr-FR Culture              2008-10-01T17:04:32.0000000
        //
        //    r Format Specifier      de-DE Culture            Wed, 01 Oct 2008 17:04:32 GMT
        //    r Format Specifier      en-US Culture            Wed, 01 Oct 2008 17:04:32 GMT
        //    r Format Specifier      es-ES Culture            Wed, 01 Oct 2008 17:04:32 GMT
        //    r Format Specifier      fr-FR Culture            Wed, 01 Oct 2008 17:04:32 GMT
        //
        //    s Format Specifier      de-DE Culture                      2008-10-01T17:04:32
        //    s Format Specifier      en-US Culture                      2008-10-01T17:04:32
        //    s Format Specifier      es-ES Culture                      2008-10-01T17:04:32
        //    s Format Specifier      fr-FR Culture                      2008-10-01T17:04:32
        //
        //    t Format Specifier      de-DE Culture                                    17:04
        //    t Format Specifier      en-US Culture                                  5:04 PM
        //    t Format Specifier      es-ES Culture                                    17:04
        //    t Format Specifier      fr-FR Culture                                    17:04
        //
        //    T Format Specifier      de-DE Culture                                 17:04:32
        //    T Format Specifier      en-US Culture                               5:04:32 PM
        //    T Format Specifier      es-ES Culture                                 17:04:32
        //    T Format Specifier      fr-FR Culture                                 17:04:32
        //
        //    u Format Specifier      de-DE Culture                     2008-10-01 17:04:32Z
        //    u Format Specifier      en-US Culture                     2008-10-01 17:04:32Z
        //    u Format Specifier      es-ES Culture                     2008-10-01 17:04:32Z
        //    u Format Specifier      fr-FR Culture                     2008-10-01 17:04:32Z
        //
        //    U Format Specifier      de-DE Culture     Donnerstag, 2. Oktober 2008 00:04:32
        //    U Format Specifier      en-US Culture   Thursday, October 02, 2008 12:04:32 AM
        //    U Format Specifier      es-ES Culture    jueves, 02 de octubre de 2008 0:04:32
        //    U Format Specifier      fr-FR Culture            jeudi 2 octobre 2008 00:04:32
        //
        //    Y Format Specifier      de-DE Culture                             Oktober 2008
        //    Y Format Specifier      en-US Culture                            October, 2008
        //    Y Format Specifier      es-ES Culture                          octubre de 2008
        //    Y Format Specifier      fr-FR Culture                             octobre 2008
        */
    }
}


/*
 using System;
 using System.Globalization;

public class MainClass {
    public static void Main(string[] args)  {
        DateTime dt = DateTime.Now;
        String[] format = {
            "d", "D",
            "f", "F",
            "g", "G",
            "m",
            "r",
            "s",
            "t", "T",
            "u", "U",
            "y",
            "dddd, MMMM dd yyyy",
            "ddd, MMM d \"'\"yy",
            "dddd, MMMM dd",
            "M/yy",
            "dd-MM-yy",
        };
        String date;
        for (int i = 0; i < format.Length; i++) {
            date = dt.ToString(format[i], DateTimeFormatInfo.InvariantInfo);
            Console.WriteLine(String.Concat(format[i], " :" , date));
        }

   /** Output.
    *
    * d :08/17/2000
    * D :Thursday, August 17, 2000
    * f :Thursday, August 17, 2000 16:32
    * F :Thursday, August 17, 2000 16:32:32
    * g :08/17/2000 16:32
    * G :08/17/2000 16:32:32
    * m :August 17
    * r :Thu, 17 Aug 2000 23:32:32 GMT
    * s :2000-08-17T16:32:32
    * t :16:32
    * T :16:32:32
    * u :2000-08-17 23:32:32Z
    * U :Thursday, August 17, 2000 23:32:32
    * y :August, 2000
    * dddd, MMMM dd yyyy :Thursday, August 17 2000
    * ddd, MMM d "'"yy :Thu, Aug 17 '00
    * dddd, MMMM dd :Thursday, August 17
    * M/yy :8/00
    * dd-MM-yy :17-08-00
    */
    }
} 
*/