using NHamcrest;
using NHamcrest.Core;
using System;
using System.Threading;

namespace training.automation.common.Utilities
{
    public static class TestHelper
    {
        public static void AssertThat<T>(T actual, IMatcher<T> matcher, string stepDescription)
        {
            AssertThat(actual, matcher, stepDescription, true);
        }

        public static void AssertThat<T>(T actual, IMatcher<T> matcher, string stepDescription, bool takeScreenshot)
        {
            try
            {
                if (!matcher.Matches(actual))
                {
                    StringDescription description = new StringDescription();

                    description.AppendText(stepDescription)
                                .AppendText("\nExpected: ")
                                .AppendDescriptionOf(matcher)
                                .AppendText("\n     but: ");

                    matcher.DescribeMismatch(actual, description);

                    throw new Exception(string.Format("Failed to assert that actual: \"{0}\" - is equal to expected: \"{1}\"", actual, matcher));
                }
            }
            catch (Exception e)
            {
                string ErrorMessage = string.Format("{0} failed. {1} {2}", stepDescription, "\n", e.Message);
                HandleException(ErrorMessage, e);
            }

        }

        public static void HandleException(string ErrorMessage, Exception e)
        {
            HandleException(ErrorMessage, e, false);
        }

        public static void HandleException(string ErrorMessage, Exception e, bool takeScreenshot)
        {
            string exception = string.Format("{0} : {1} : ", ErrorMessage, e);

            throw new ArgumentException(e.Message, e);
        }

        public static void SleepInSeconds(int seconds)
        {
            try
            {
                Thread.Sleep(seconds * 1000);
            }
            catch (ThreadInterruptedException e)
            {
                string errorMessage = string.Format("Unable to perform the requested '{0}' second sleep", seconds);
                HandleException(errorMessage, e);
            }
        }
    }
}
