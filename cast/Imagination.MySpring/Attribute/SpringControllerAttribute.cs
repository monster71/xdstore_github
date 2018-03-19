﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imagination.MySpring.Menu;

namespace Imagination.MySpring.Attribute
{
    public class SpringControllerAttribute:BaseSpringAttribute
    {
        public SpringControllerAttribute() : base(MenuSpringType.TYPE_CONTROLLER)
        {
        }
    }
}
