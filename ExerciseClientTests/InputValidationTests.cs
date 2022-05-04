using System.Collections.Generic;
using ExerciseTrackerClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExerciseClientTests
{
    [TestClass]
    public class InputValidationTests
    {
        [TestMethod]
        public void IdValidation_ValidInput_OutIdMatchTrue()
        {
            // Arrange
            List<Workout> exampleWorkouts = new();
            string id = "1";
            exampleWorkouts.Add(new Workout() { WorkoutsId = int.Parse(id) });

            // Act
            bool isValid = InputValidationService.IdValidation(exampleWorkouts, id);

            // Assert
            Assert.IsTrue(isValid, "Input and Id is a match but method does not return True");
        }

        [TestMethod]
        public void IdValidation_ValidInput_OutGuardClauseTrue()
        {
            // Arrange
            List<Workout> exampleWorkouts = new();
            exampleWorkouts.Add(new Workout() { WorkoutsId = 1 });
            string guard = "return";

            // Act
            bool guardIsValid = InputValidationService.IdValidation(exampleWorkouts, guard);
            
            // Assert
            Assert.IsTrue(guardIsValid, "Return string is correct but method does not return True");
        }

        [TestMethod]
        public void IdValidation_InvalidId_OutIdMatchFalse()
        {
            // Arrange
            List<Workout> exampleWorkouts = new();
            string invalidNum = "2";
            exampleWorkouts.Add(new Workout(){ WorkoutsId = 1 });

            // Act
            bool inputNumIsInvalid = InputValidationService.IdValidation(exampleWorkouts, invalidNum);

            // Assert
            Assert.IsFalse(inputNumIsInvalid, "Input and Id is not a match but does not return False");
        }

        [TestMethod]
        public void IdValidation_InvalidInput_OutIdMatchFalse()
        {
            // Arrange
            List<Workout> exampleWorkouts = new();
            string empty = "";
            exampleWorkouts.Add(new Workout() { WorkoutsId = 1 });

            // Act
            bool stringInputIsInvalid = InputValidationService.IdValidation(exampleWorkouts, empty);

            // Assert
            Assert.IsFalse(stringInputIsInvalid, "Input is not a valid number but does not return False");
        }
    }

    [TestClass]
    public class DateValidationTests
    {
        [TestMethod]
        public void DateValidation_ValidInput_OutDateFormatTrue()
        {
            // Arrange
            string input = "10:40";

            // Act
            bool validFormat = InputValidationService.DateValidation(input);

            // Assert
            Assert.IsTrue(validFormat, "Input is correct but does not return True");
        }

        [TestMethod]
        public void DateValidation_ValidGuard_OutGuardTrue()
        {
            // Arrange
            string input = "return";

            // Act
            bool validGuard = InputValidationService.DateValidation(input);

            // Assert
            Assert.IsTrue(validGuard, "Guard statement is correct but does not return True");
        }

        [TestMethod]
        public void DateValidation_InvalidInput_OutDateFormatFalse()
        {
            // Arrange
            string input = "!0:00";

            // Act
            bool validFormat = InputValidationService.DateValidation(input);

            // Assert
            Assert.IsFalse(validFormat, "Input format is not correct but does not return False");
        }
    }
}