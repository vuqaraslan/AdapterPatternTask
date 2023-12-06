//using Lesson3HomeWorkDesignPat.Date_28_11_23.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson3HomeWorkDesignPat.Date_28_11_23.Services
//{
//    public class OperationsAdapter
//    {
//        public interface IAdapter
//        {
//            void Write(object obj, string filename);
//            AnketData Read(string filename);

//        }
//        public class JsonOperation : IAdapter
//        {
//            private readonly FileHelper _jsonHelper;
//            public JsonOperation()
//            {
//                _jsonHelper = new FileHelper();
//            }
//            public AnketData Read(string filename)
//            {
//                throw new NotImplementedException();
//            }

//            public void Write(object obj, string filename)
//            {
//                _jsonHelper.Write(obj, filename);
//            }
//        }

//        public class XmlOperations : IAdapter
//        {
//            private readonly XmlHelper _xmlHelper;

//            public XmlOperations()
//            {
//                _xmlHelper = new XmlHelper();
//            }
//            public AnketData Read(string filename)
//            {
//                var data = _xmlHelper.Read(filename);
//                return data;
//            }

//            public void Write(object obj, string filename)
//            {
//                _xmlHelper.Write(obj, filename);
//            }
//        }

//        public class Converter
//        {

//        }
//    }
//}
