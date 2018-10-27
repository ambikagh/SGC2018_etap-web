﻿////////////////////////////////////////////////////////
// Copyright (c) 2018 Sameer Khandekar                //
// License: MIT License.                              //
////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Threading.Tasks;

namespace CloudClientLibrary
{
    public interface IImageClient
    {
        Task<string> UploadImage(Stream imageStream);
    }
}