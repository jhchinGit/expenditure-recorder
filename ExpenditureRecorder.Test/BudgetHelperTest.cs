using ExpenditureRecorder.Data.Enums;
using ExpenditureRecorder.Data.Exceptions;
using ExpenditureRecorder.Services;
using NUnit.Framework;

namespace ExpenditureRecorder.Test
{
    public class BudgetHelperTest
    {
        [Test]
        public void GivenAmount_GenerateSameBudgetAmount()
        {
            var budget = BudgetHelper.Generate(100);
            Assert.AreEqual(100, budget.Amount);
        }

        [Test]
        public void GivenNegativeBudget_ThrowBudgetCannotBeNegativeValueException()
        {
            Assert.Throws<BudgetCannotBeNegativeValue>(() => BudgetHelper.Generate(-1));
        }

        [Test]
        public void GivenAlertPercentage_GenerateSameBudgetAlertPercentage()
        {
            var budget = BudgetHelper.Generate(100, 1);
            Assert.AreEqual(1, budget.AlertPercentage);
        }

        [Test]
        public void GivenMoreThanHundredPercentOfAlertPercentage_ThrowBudgetAlertPercentageCannotBeMoreThanHundredPercentException()
        {
            Assert.Throws<BudgetAlertPercentageCannotBeMoreThanHundredPercent>(() => BudgetHelper.Generate(1, 101));
        }

        [Test]
        public void GivenNegativeAlertPercentage_ThrowBudgetAlertPercentageCannotBeNegativeValueException()
        {
            Assert.Throws<BudgetAlertPercentageCannotBeNegativeValue>(() => BudgetHelper.Generate(1, -1));
        }

        [Test]
        public void GivenTimeline_GenerateBudgetWithGivenTimeline()
        {
            var budget = BudgetHelper.Generate(100, BudgetTimeline.Annually);
            Assert.AreEqual(BudgetTimeline.Annually, budget.Timeline);
        }

        [Test]
        public void GivenNegativeBudgetAndPositiveAlertPercentage_ThrowBudgetCannotBeNegativeValueException()
        {
            Assert.Throws<BudgetCannotBeNegativeValue>(() => BudgetHelper.Generate(-1, 1));
        }

        [Test]
        public void GivenNegativeBudgetAndTimeline_ThrowBudgetCannotBeNegativeValueException()
        {
            Assert.Throws<BudgetCannotBeNegativeValue>(() => BudgetHelper.Generate(-1, BudgetTimeline.Annually));
        }

        [Test]
        public void GivenNegativeBudgetAndAlertPercentageAndTimeline_ThrowBudgetCannotBeNegativeValueException()
        {
            Assert.Throws<BudgetCannotBeNegativeValue>(() => BudgetHelper.Generate(-1, 1, BudgetTimeline.Annually));
        }

        [Test]
        public void GivenBudgetAndNegativeAlertPercentageAndTimeline_ThrowBudgetCannotBeNegativeValueException()
        {
            Assert.Throws<BudgetAlertPercentageCannotBeNegativeValue>(() => BudgetHelper.Generate(1, -1, BudgetTimeline.Annually));
        }

        [Test]
        public void GivenBudgetAnd101AlertPercentageAndTimeline_ThrowBudgetCannotBeNegativeValueException()
        {
            Assert.Throws<BudgetAlertPercentageCannotBeMoreThanHundredPercent>(() => BudgetHelper.Generate(1, 101, BudgetTimeline.Annually));
        }
    }
}