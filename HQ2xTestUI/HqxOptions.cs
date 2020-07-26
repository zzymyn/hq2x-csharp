// (C) Copyright 2011 Ivan Neeson
// Use, modification and distribution are subject to the 
// Boost Software License, Version 1.0. (See accompanying file 
// LICENSE_1_0.txt or copy at http://www.boost.org/LICENSE_1_0.txt)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace HQ2xTestUI
{
    public enum HQ2xMode
    {
        ColorOnly,
        ColorSimpleAlpha,
        ColorAlpha,
    }

    public class HqxOptions
    {
        [Category("Mode")]
        public HQ2xMode Mode { get; set; }

        [Category("Threshold")]
        public byte YThreshold { get; set; }

        [Category("Threshold")]
        public byte UThreshold { get; set; }

        [Category("Threshold")]
        public byte VThreshold { get; set; }

        [Category("Threshold")]
        public byte AThreshold { get; set; }
        
        public HqxOptions()
        {
            Mode = HQ2xMode.ColorAlpha;
            YThreshold = 48;
            UThreshold = 7;
            VThreshold = 6;
            AThreshold = 0;
        }
    }
}
