/* File: Program.cs                   
 * Author: Daniel T. G. Mariano          
 * Email: dtgmariano@gmail.com           
 * Date: 17/09/2015                     
 * Update: 17/09/2015
 * Version: 1.0
 */
namespace CSharpXMLSerialization
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            /*Creates an User object*/
            User u1 = new User();
            u1.id = 2481;
            u1.name = "John Doe";
            u1.gender = "Male";
            u1.species = "Alien";
            
            XMLHandler.SaveXMLFile(u1);


            User u2 = XMLHandler.OpenXMLFile_TrialData(Settings.Default.folder + Settings.Default.filename);

            Console.WriteLine();
        }

        
    }
}
