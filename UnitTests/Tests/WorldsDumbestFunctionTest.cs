using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{
    public static class WorldsDumbestFunctionTest
    {
        public static void WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString()
        {
            try
            {
                //Arrange - Go get your variables, whatever you need, your classes, your functions
                int num = 0;
                WorldsDumbestFunction worldsDumbest = new WorldsDumbestFunction();

                //Act - Execute this function
                string result = worldsDumbest.ReturnsPikachuIfZero(num);

                //Assert - Whatever is returned is it what you want?
                if(result == "PIKACHU!")
                {
                    Console.WriteLine("Passed: WorldsDumbestFunction.ReturnsPikachuIfZero_ReturnsString");
                }
                else
                {
                    Console.WriteLine("Failed: WorldsDumbestFunction.ReturnsPikachuIfZero_ReturnsString");
                }
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex);
            }        
        }
            
    }
}
