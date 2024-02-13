using System;
using DevExpress.Mvvm;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using EPLE;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DevExpress.CodeParser;
using DevExpress.XtraRichEdit.Layout;
using static DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace LARVA_UI.ViewModels.SettingViewModel
{
    class ViewModel
    {
        public ViewModel()
        {
            Number = 1;
            TargetPosition = 100.55;
            TargetSpeed = 20.88;
            Description = "Clean";
        }

        public int Number { get; set; }
        public Double TargetPosition { get; set; }
        public Double TargetSpeed { get; set; }
        public string Description { get; set; }
    }


    public class AxisModelView : INotifyPropertyChanged
    {
        private int _Number;
        public int Number
        {
            get
            {
                return _Number;
            }
            set
            {
                _Number = value;
                RaisePropertyChanged();
            }
        }

        private Double _TargetPosition;
        public Double TargetPosition
        {
            get
            {
                return _TargetPosition;
            }
            set
            {
                _TargetPosition = value;
                RaisePropertyChanged();
            }
        }

        private Double _TargetSpeed;
        public Double TargetSpeed
        {
            get
            {
                return _TargetSpeed;
            }
            set
            {
                _TargetSpeed = value;
                RaisePropertyChanged();
            }
        }

        private string _Description;
        public String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
                RaisePropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //private void RaisePropertyChanged()
        //{
        //    throw new NotImplementedException();
        //}

        private void RaisePropertyChanged([CallerMemberName] string propertyname = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
            // PeopertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
