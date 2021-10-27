# Nlog_working
Steps to use Nlog in a project are as follows:

Go to VSC -> create a console application -> open it.

Go to tools -> select NuGet package manager -> select manage NuGet packages for solutions ->browse nlog->select NLog and tick the project checkbox then install it .Now search for NLog config and install the latest version.

On the right side select NLog.config file to open (You won't be able to write in it).

check the properties of NLog.config and copy the path of it from there.

Open cmd -> write cd pathOfTheFile (till any) ->notepad NLog.config.

Remove comments like <!-- --> from targets and rules.

Change type "file" to "Console".

 <target xsi:type="Console" name="f" fileName="" layout="${longdate} ${uppercase:${level}} ${message}" /> ->save it
 
 Create a class in VSC project and make it public and write the following :
 using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace classwork_Nlog
{

   public class nlog
    {
        public Logger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string input)
        {
            logger.Debug(input);
        }

        public void LogError(string input)
        {
            logger.Error(input);
        }

        public void LogWarn(string input)
        {
            logger.Warn(input);
        }

        public void LogInfo(string input)
        {
            logger.Info(input);
        }
    }
}

//Dont forget to add using NLog//

Go to program.cs -> Create objects and call methods like

static void Main()
          {
            Console.WriteLine("Hello World!");

            nlog nlogObject = new nlog();
            nlogObject.LogDebug("Debugging the code");
            }
            
Save it and run it .You'll get NLog message in console.

Now adding one more class to add two numbers and display information and error in NLog


using System;
using System.Collections.Generic;
using System.Text;

namespace classwork_Nlog
{

   public class addNum
    {
    //created object of previous class
        nlog log = new nlog();
    //created parametrised function
        public int sum(int a,int b)
        {
            log.LogInfo("a : " + a + " " + "b :" + b);
            if (a == 0 || b == 0)
            {
            // calling LogDebug and LogError method
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


creating objects of it in Program.cs
            addNum obj2 = new addNum();
            obj2.sum(4, 4);
            
Save it and run it .You'll get info on console

Let's store it in file .

Go to folder of the project ->create a txt file to store logs

For that Go to cmd-> again open the notepad file -> change the type to "File" and name="console"

filename =path of the notepad file created in the folder
         
         <target xsi:type="File" name="console" fileName="C:\Users\hp\source\repos\classwork Nlog\classwork Nlog\logTrack.txt"
            layout="${longdate} ${uppercase:${level}} ${message}" />
   
  </targets>

  <rules>
    
  
    <logger name="*" minlevel="Debug" writeTo="console" />
    
  </rules>
  
  Save it and Run it 
  
  You'll get logs stored each time in notepad file.In this way it will keep track of all the info,debug and errors
  
  In this repository logTrack file is used to store logs.
