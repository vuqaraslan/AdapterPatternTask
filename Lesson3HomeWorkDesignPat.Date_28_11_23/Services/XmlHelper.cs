using Lesson3HomeWorkDesignPat.Date_28_11_23.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Lesson3HomeWorkDesignPat.Date_28_11_23.Services
{
    public class XmlHelper
    {

        //public static void Write<T>(object obj, string filename)
        //{
        //    var xml = new XmlSerializer(typeof(T));
        //    using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
        //    {
        //        xml.Serialize(fs, obj);
        //    }
        //}

        public static void Write(object obj, string filename)
        {
            var xml = new XmlSerializer(typeof(AnketData));
            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, obj);
            }
        }

        //public static T Read<T>(string filename)
        //{
        //    T data = default(T);

        //    var xml = new XmlSerializer(typeof(T));
        //    using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
        //    {
        //        //data = xml.Deserialize(fs) as AnketData;
        //        var v = typeof(T);
        //        data = xml.Deserialize(fs) as v;
        //        return data;
        //    }
        //}



        //public static AnketData Read<T>(string filename)
        public static AnketData Read(string filename)
        {
            AnketData data = null;

            var xml = new XmlSerializer(typeof(AnketData));
            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                data = xml.Deserialize(fs) as AnketData;
                return data;
            }
        }

    }
}
