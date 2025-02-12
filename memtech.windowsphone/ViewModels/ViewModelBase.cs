﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace memtech.windowsphone.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        /**
         * Returns true if running inside a design tool (to determine fake data)
         */
        public bool IsDesignTime()
        {
            return System.ComponentModel.DesignerProperties.IsInDesignTool;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
