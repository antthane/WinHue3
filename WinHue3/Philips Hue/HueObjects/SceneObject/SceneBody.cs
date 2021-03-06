﻿using System.Runtime.Serialization;
using WinHue3.Philips_Hue.HueObjects.Common;
using WinHue3.ViewModels;

namespace WinHue3.Philips_Hue.HueObjects.SceneObject
{
    [DataContract]
    public class SceneBody : ValidatableBindableBase
    {
        private string _scene;

        [HueProperty,DataMember]
        public string scene
        {
            get => _scene;
            set => SetProperty(ref _scene,value);
        }
    }
}
