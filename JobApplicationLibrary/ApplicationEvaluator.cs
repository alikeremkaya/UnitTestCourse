using JobApplicationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationLibrary
{
    public class ApplicationEvaluator
    {
        public ApplicationEvaluator()
        {
                
        }
        private const int minAge = 18;  

        public ApplicationResult Evaluate(JobApplication form)
        {
            if (form.Applicant.Age < 18)
                return ApplicationResult.AutoRejected;
            return ApplicationResult.AutoRejected;

        }
        public enum ApplicationResult
        {
            AutoRejected,
            TransferredToHR,
            TransferredToLead,
            TransferredToCTO,
            AutoAccepted

        }
    }
}
