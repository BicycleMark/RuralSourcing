using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace RuralSourcing
{

    //Task 1
    public class DateTimeToHumanReadableFormFormatter
    {
        
        static Dictionary<TimeSpan, string> formatDictionary;
        static DateTimeToHumanReadableFormFormatter()
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0);
            formatDictionary = new Dictionary<TimeSpan, string>();
            formatDictionary.Add(new TimeSpan(0, 0, 0, 0), "now");
            formatDictionary.Add(new TimeSpan(0, 0, 0, 60), "now");
            formatDictionary.Add(new TimeSpan(days: 0, hours: 0, minutes: 60, seconds: 0) , "{0} minute(s) ago");
            formatDictionary.Add(new TimeSpan(days: 0, hours: 24, minutes: 0, seconds: 0) , "{0} hour(s) ago");
            formatDictionary.Add(new TimeSpan(days: 7, hours: 0, minutes:  0, seconds: 1) , "{0} day(s) ago");
            formatDictionary.Add(new TimeSpan(days: 10000, hours: 0, minutes: 0, seconds: 0), "yyyy-M-dd h:m:s");     
        }
    
        
        public string Format(DateTime date, DateTime current)
        {
            var ticks = (current - date);
            // Fixed the Application with Defintion that took milliseconds out of the calculation
            // These milliseconds were causing 7 day logic to fail
            var deltaTicks = new TimeSpan(ticks.Days, ticks.Hours, ticks.Minutes, ticks.Seconds);
            var lstTicks = formatDictionary.Keys.ToArray<TimeSpan>();
            TimeSpan ts = lstTicks[lstTicks.Count() - 1];
            for (int i = 1; i < lstTicks.Length; i++)
            {
                ts = lstTicks[i];
                if (deltaTicks >= lstTicks[i-1] && deltaTicks < lstTicks[i] )
                {
                    switch(i)
                    {
                        case (1):
                            return formatDictionary[ts];           
                        case (2):
                            return String.Format(formatDictionary[ts], current.Minute - date.Minute);
                        case (3):
                            return String.Format(formatDictionary[ts], current.Hour - date.Hour);
                        case (4):
                            return String.Format(formatDictionary[ts], current.Day - date.Day);       
                    }
                }
            }
            return date.ToString(formatDictionary[ts]);
        }
    }
    public class SolutionIter : IEnumerable<int>
    {
        Stream _stream = null;
        List<int> lstInput;
        public SolutionIter(Stream stream)
        {
            _stream = stream;
            byte[] buffer = new byte[stream.Length];
            int len = (int)stream.Length;
            var n = _stream.Read(buffer, 0, len);
            var streamAsString = System.Text.Encoding.Default.GetString(buffer);
            var arr = streamAsString.Split('\xA');
            lstInput = new List<int>();
            foreach (var item in arr)
            {
                int result;
                if (int.TryParse(item, out result) && result <= 1000000000)
                    lstInput.Add(result);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return lstInput.GetEnumerator();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            foreach (var n in lstInput)
            {
                yield return n;
            }
        }
    }
}
