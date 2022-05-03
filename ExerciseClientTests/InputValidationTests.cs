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
            List<Workout> mockList = new();
            mockList.Add(new Workout() { WorkoutsId = 1 });
            string id = "1";

            bool idOut = InputValidationService.IdValidation(mockList, id);

            Assert.IsTrue(idOut);
        }

        [TestMethod]
        public void IdValidation_ValidInput_OutGuardTrue()
        {
            List<Workout> mockList = new();
            mockList.Add(new Workout() { WorkoutsId = 1 });
            string guard = "return";

            bool guardOut = InputValidationService.IdValidation(mockList, guard);

            Assert.IsTrue(guardOut);
        }

        [TestMethod]
        public void IdValidation_InvalidId_OutIdMatchFalse()
        {
            List<Workout> mockList = new();
            mockList.Add(new Workout(){ WorkoutsId = 1 });
            string invalidNum = "2";

            bool invalidNumCheck = InputValidationService.IdValidation(mockList, invalidNum);

            Assert.IsFalse(invalidNumCheck);
        }

        [TestMethod]
        public void IdValidation_InvalidInput_OutIdMatchFalse()
        {
            List<Workout> mockList = new();
            mockList.Add(new Workout() { WorkoutsId = 1 });
            string empty = "";

            bool emptyCheck = InputValidationService.IdValidation(mockList, empty);

            Assert.IsFalse(emptyCheck);
        }
    }

    [TestClass]
    public class DateValidationTests
    {
        [TestMethod]
        public void DateValidation_ValidInput_OutDateFormatTrue()
        {
            string input = "10:40";

            bool validFormat = InputValidationService.DateValidation(input);

            Assert.IsTrue(validFormat);
        }

        [TestMethod]
        public void DateValidation_ValidGuard_OutGuardTrue()
        {
            string input = "return";

            bool validGuard = InputValidationService.DateValidation(input);

            Assert.IsTrue(validGuard);
        }

        [TestMethod]
        public void DateValidation_InvalidInput_OutDateFormatFalse()
        {
            string input = "!0:00";

            bool validFormat = InputValidationService.DateValidation(input);

            Assert.IsFalse(validFormat);
        }
    }
}