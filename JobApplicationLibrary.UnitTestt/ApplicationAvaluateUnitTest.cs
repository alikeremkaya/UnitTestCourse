using NUnit.Framework;
using static JobApplicationLibrary.ApplicationEvaluator;


namespace JobApplicationLibrary.UnitTestt
{
    public class ApplicationAvaluateUnitTest
    {
        //UnitOfWork_Condition_ExpectedResult

        [Test]
        public void Application_WithUnderAge_TransferredToAutoRejected()
        {
            //arrange 
            var evaluator = new ApplicationEvaluator();
            var form = new Models.JobApplication()
            {
                Applicant = new Models.Applicant()
                {
                    Age = 17
                }
            };  
            //act
            var appResult = evaluator.Evaluate(form);
            //assert
            Assert.AreEqual( appResult,ApplicationResult.AutoRejected);
        }






    }
    
  




}