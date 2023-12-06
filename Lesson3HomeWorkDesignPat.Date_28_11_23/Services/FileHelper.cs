using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using System.Windows.Controls;
using System.Runtime.ConstrainedExecution;
using Lesson3HomeWorkDesignPat.Date_28_11_23.Models;

namespace Lesson3HomeWorkDesignPat.Date_28_11_23.Services
{
    public class FileHelper
    {

        public static void Write(object obj, string filename)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter(filename))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, obj);
                }
            }
        }

        public static AnketData Read(string filename) 
        {
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader(filename))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    var result = serializer.Deserialize<AnketData>(jr);
                    return result;
                }
            }
        }

        //public static T Read<T>(string filename) where T : class
        //{
        //    var serializer = new JsonSerializer();
        //    using (var sr = new StreamReader(filename))
        //    {
        //        using (var jr = new JsonTextReader(sr))
        //        {
        //            var result = serializer.Deserialize<T>(jr);
        //            return result;
        //        }
        //    }
        //}



    }
}
