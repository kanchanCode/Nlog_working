using System;
using System.Collections.Generic;
using System.Text;

namespace classwork_Nlog
{
   public class addNum
    {
        nlog log = new nlog();

        public int sum(int a,int b)
        {
            log.LogInfo("a : " + a + " " + "b :" + b);
            if (a == 0 || b == 0)
            {
                log.LogDebug("debug is successful");
                log.LogError("Error in a or b's value ");
                return 0;
            }
            int c = a + b;
            log.LogDebug("debug done ");
            log.LogDebug("sum is "+c);
            return c;
        }
    }
}
