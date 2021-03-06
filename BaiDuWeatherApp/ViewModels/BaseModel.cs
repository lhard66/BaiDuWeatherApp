﻿using System.Runtime.CompilerServices;

namespace BaiDuWeatherApp.ViewModels
{
    public class BaseModel:NotifyPropertyChange
    {
        protected void SetProperty<TProperty>(ref TProperty orign, TProperty newObj, [CallerMemberName]string properName = null)
        {
            if (object.Equals(orign, newObj))
            {
                return;
            }
            orign = newObj;
            if (string.IsNullOrEmpty(properName))
            {
                return;
            }
            OnNotifyPropertyChanged(properName);
        }
    }
}
