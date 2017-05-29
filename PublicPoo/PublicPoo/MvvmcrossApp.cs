﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using PublicPoo.ViewModels;
using PublicToilet.Services;
using PublicToilet.Services.interfaces;

namespace PublicPoo
{
    public class MvvmcrossApp : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ToiletsViewModel>();
        }
    }
}
