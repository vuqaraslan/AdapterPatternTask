using Lesson3HomeWorkDesignPat.Date_28_11_23.Commands;
using Lesson3HomeWorkDesignPat.Date_28_11_23.Models;
using Lesson3HomeWorkDesignPat.Date_28_11_23.Services;
using Lesson3HomeWorkDesignPat.Date_28_11_23.Views;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Lesson3HomeWorkDesignPat.Date_28_11_23.ViewModels
{


    //public interface IAdapter
    //{
    //    void Write(object obj, string filename);
    //    AnketData Read(string filename);

    //}
    //public class JsonOperation : IAdapter
    //{
    //    private readonly FileHelper _jsonHelper;
    //    public JsonOperation()
    //    {
    //        _jsonHelper = new FileHelper();
    //    }
    //    public AnketData Read(string filename)
    //    {
    //        var data = _jsonHelper.Read(filename);
    //        return data;
    //    }

    //    public void Write(object obj, string filename)
    //    {
    //        _jsonHelper.Write(obj, filename);
    //    }
    //}

    //public class XmlOperations : IAdapter
    //{
    //    private readonly XmlHelper _xmlHelper;

    //    public XmlOperations()
    //    {
    //        _xmlHelper = new XmlHelper();
    //    }
    //    public AnketData Read(string filename)
    //    {
    //        var data = _xmlHelper.Read(filename);
    //        return data;
    //    }

    //    public void Write(object obj, string filename)
    //    {
    //        _xmlHelper.Write(obj, filename);
    //    }
    //}

    //public class Converter
    //{

    //}

    public class MainViewModel : BaseViewModel
    {
        private AnketData anketData;
        public AnketData AnketData
        {
            get { return anketData; }
            set { anketData = value; OnPropertyChanged(); }
        }

        private bool isCheckJson;
        public bool IsCheckJson
        {
            get { return isCheckJson; }
            set { isCheckJson = value; OnPropertyChanged(); }
        }

        private bool isCheckXML;
        public bool IsCheckXML
        {
            get { return isCheckXML; }
            set { isCheckXML = value; OnPropertyChanged(); }
        }

        public RelayCommand SaveBtnCommand { get; set; }
        public RelayCommand ReadBtnCommand { get; set; }
        public MainViewModel()
        {
            AnketData = new AnketData();

            IsCheckJson = true;
            IsCheckXML = false;

            SaveBtnCommand = new RelayCommand((obj) =>
            {
                if (IsCheckJson)
                {

                    FileHelper.Write(AnketData, App.AnketFileNameJson);
                    MessageBox.Show($"Anket data is saved like Json!");
                    AnketData = new AnketData();
                }
                else if (IsCheckXML)
                {
                    XmlHelper.Write(AnketData, App.AnketFileNameXML);
                    MessageBox.Show($"Anket data is saved like XML!");
                    AnketData = new AnketData();
                }
            });

            ReadBtnCommand = new RelayCommand((obj) =>
            {
                if (IsCheckJson)
                {
                    var data = FileHelper.Read(App.AnketFileNameJson);
                    AnketData = data;
                }
                else if (IsCheckXML)
                {
                    var data = XmlHelper.Read(App.AnketFileNameXML);
                    AnketData = data;
                }
            });

            //SaveBtnCommand = new RelayCommand((obj) =>
            //{
            //    //if(File.Exists(App.AnketFileName))
            //    // {
            //    //     var data=FileHelper.Read<AnketData>(App.AnketFileName);
            //    // }

            //    if (IsCheckJson)
            //    {

            //    FileHelper.Write(AnketData, App.AnketFileNameJson);
            //    MessageBox.Show($"Anket data is saved!");
            //    AnketData = new AnketData();
            //    }
            //    else if (IsCheckXML)
            //    {
            //        XmlHelper.Write<AnketData>(AnketData, App.AnketFileNameXML);
            //        MessageBox.Show($"Anket data is saved!");
            //        AnketData = new AnketData();
            //    }
            //}
            ////(pred) =>
            ////{
            ////    if (IsCheckJson)
            ////    {
            ////        return true;
            ////    }
            ////    else
            ////    {
            ////        return false;
            ////    }
            ////}
            //);

            //ReadBtnCommand = new RelayCommand((obj) =>
            //{
            //    //if (File.Exists(App.AnketFileName))
            //    //{
            //    //    var data=FileHelper.Read<AnketData>(App.AnketFileName);
            //    //    AnketData = data;
            //    //}
            //    //else
            //    //{
            //    //}
            //    if(IsCheckJson)
            //    {

            //    var data = FileHelper.Read<AnketData>(App.AnketFileNameJson);
            //    AnketData = data;
            //    }
            //    else if(IsCheckXML)
            //    {
            //        var data = XmlHelper.Read<AnketData>(App.AnketFileNameXML);
            //        AnketData = data;
            //    }
            //});

        }

    }
}
