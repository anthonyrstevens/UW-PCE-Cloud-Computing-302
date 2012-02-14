using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwsUtils
{
    public class Assert
    {
        public static void Fail(Func<bool> assertion, string message)
        {
            if (!assertion())
            {
                throw new Exception(String.Format("Assertion failed: {0}", message));
            }
        }
    }
}
