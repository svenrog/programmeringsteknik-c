using System;
using System.Collections.Generic;
using System.Text;

namespace Users.Common.Database
{
    public class GlobalVariables
    {
        private static string _pepper = "z0AYHca$nk@5Lhr:vq7y;6e4P61&^U71coEl?dhyT$u8l;$LcG";
        public static string Pepper ()
        {
            return _pepper;
        }
    }
}
