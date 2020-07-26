// (C) Copyright 2011 Ivan Neeson
// Use, modification and distribution are subject to the 
// Boost Software License, Version 1.0. (See accompanying file 
// LICENSE_1_0.txt or copy at http://www.boost.org/LICENSE_1_0.txt)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HQ2x
{
    public interface ILerp
    {
        Color Lerp(Color colour1, int factor1, Color colour2, int factor2, Color colour3, int factor3);
    }
}
