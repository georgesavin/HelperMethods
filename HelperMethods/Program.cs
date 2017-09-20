using System;

namespace HelperMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {

			string myValue = superSecretFormula();
			Console.WriteLine(myValue);
			Console.ReadLine();
			        }
		//when naming convention allows anyone who reads the code know that its a private variable, use this for helper methods

		private static string superSecretFormula()
 
         {
             
             return "HI MR. Cox!";
			// reuturn is the command to deliver it to the code that actually called it
			// Information about this assembly is defined by the following attributes. 
			// Change them to the values specific to your project.
			
			[assembly: AssemblyTitle("BranchingPart1")]
			[assembly: AssemblyDescription("")]
			[assembly: AssemblyConfiguration("")]
			[assembly: AssemblyCompany("")]
			[assembly: AssemblyProduct("")]
			[assembly: AssemblyCopyright("${AuthorCopyright}")]
			[assembly: AssemblyTrademark("")]
			[assembly: AssemblyCulture("")]
			
			// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
			// The form "{Major}.{Minor}.*" will make it update and revision,
			// and "{Major}.{Minor}.{Build}.*" will update just the revision.
			
			[assembly: AssemblyVersion("1.0.*")]
			
			// The following attributes are used to specify the signing key for the assembly, 
			// if desired. See the Mono documentation for more information about signing.
			
			//[assembly: AssemblyDelaySign(false)]
			//[assembly: AssemblyKeyFile("")]

		    }
      }
 }
       
// this code is important becaus it teaches u how helper methods work and how this will help you 
//making assemblies