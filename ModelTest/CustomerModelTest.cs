using System;
using StoreModels;
using Xunit;

namespace ModelTest 
{
    public class UnitTest1 
    {
        
          [Fact] // Fact is a testcase that doesn't have any parameters
          //Runs only once.
        public void NameSetValidData() 
        {
            //Arrange
        Customer _custTest = new Customer();
        string name = "Jimothy Birdman";

            //Act
        _custTest.FirstName = name; 

            //Assert
        Assert.NotNull(_custTest.FirstName);
        Assert.Equal(_custTest.FirstName, name);
        
        }  

        /// <summary>
        /// Will test for exception from Name Property for invalid data
        /// invalid data - not string
        /// </summary>
        [Theory] // Theory creates a parameter test case
        [InlineData("1232345A")] //InlineData is data passed to parameter of 
                        //test method
        [InlineData("WAsdsaw2")] //More test methods may be added
        public void NameShouldFailIfInvalid(string p_input);
        {
            //Arrange
            Customer _custTest = new Customer();

            //Act & Assert
            //Throws method will only pass if the code you did will
            //give an Exception
            Assert.Throws<Exception>(() => _custTest.FirstName = p_input); 
        }
    }
}