using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometricFigures.Test.Figures.Test
{
    [TestClass]
    public class Circle
    {
        //private ReportsController controller { get; set; }

        //[TestInitialize]
        //public void ReportsControllerTest_TestInitialize()
        //{
        //    controller = new ReportsController(new MockReportsControllerService(), null);
        //}

        //[TestMethod]
        //public void ReportsControllerTest_GetDateReport_ReturnsItems()
        //{
        //    //Arrange
        //    DateTime date = new DateTime(2021, 09, 1, 0, 0, 0);
        //    // Act
        //    ActionResult<Report> actionResult = controller.GetDateReport(date).Result;
        //    Report resultObject = TestHelper.GetObjectResultContent<Report>(actionResult);
        //    // Assert
        //    Assert.IsInstanceOfType(actionResult.Result, typeof(OkObjectResult));
        //    Assert.AreEqual(4, resultObject.Transactions.Count());
        //    Assert.AreEqual(4, resultObject.TotalExpense);
        //    Assert.AreEqual(205, resultObject.TotalIncome);
        //}

        //[TestMethod]
        //public void ReportsControllerTest_GetDateReport_ReturnsBadRequestResult()
        //{
        //    //Arrange
        //    DateTime date = DateTime.Now.Date.AddDays(1);
        //    // Act
        //    ActionResult<Report> actionResult = controller.GetDateReport(date).Result;
        //    // Assert
        //    Assert.IsInstanceOfType(actionResult.Result, typeof(BadRequestResult));
        //}

        //[TestMethod]
        //public void ReportsControllerTest_GetReportForPeriod_ReturnsItems()
        //{
        //    //Arrange
        //    DateTime testStartDate = new DateTime(2021, 09, 1, 0, 0, 0);
        //    DateTime testEndDate = new DateTime(2021, 09, 30, 0, 0, 0);
        //    // Act
        //    ActionResult<Report> actionResult = controller.GetReportForPeriod(testStartDate, testEndDate).Result;
        //    Report resultObject = TestHelper.GetObjectResultContent<Report>(actionResult);
        //    // Assert
        //    Assert.IsInstanceOfType(actionResult.Result, typeof(OkObjectResult));
        //    Assert.AreEqual(6, resultObject.Transactions.Count());
        //    Assert.AreEqual(6, resultObject.TotalExpense);
        //    Assert.AreEqual(255, resultObject.TotalIncome);
        //}

        //[TestMethod]
        //public void ReportsControllerTest_GetReportForPeriod_StartDateFromFuture_ReturnsBadRequestResult()
        //{
        //    //Arrange
        //    DateTime testStartDate = DateTime.Now.Date.AddDays(1);
        //    DateTime testEndDate = new DateTime(2021, 09, 30, 0, 0, 0);
        //    // Act
        //    ActionResult<Report> actionResult = controller.GetReportForPeriod(testStartDate, testEndDate).Result;
        //    // Assert
        //    Assert.IsInstanceOfType(actionResult.Result, typeof(BadRequestResult));
        //}

        //[TestMethod]
        //public void ReportsControllerTest_GetReportForPeriod_EndDateFromFuture_ReturnsBadRequestResult()
        //{
        //    //Arrange
        //    DateTime testStartDate = new DateTime(2021, 09, 1, 0, 0, 0);
        //    DateTime testEndDate = DateTime.Now.Date.AddDays(1);
        //    // Act
        //    ActionResult<Report> actionResult = controller.GetReportForPeriod(testStartDate, testEndDate).Result;
        //    // Assert
        //    Assert.IsInstanceOfType(actionResult.Result, typeof(BadRequestResult));
        //}

        //[TestMethod]
        //public void ReportsControllerTest_GetReportForPeriod_InvalidPeriod_ReturnsBadRequestResult()
        //{
        //    //Arrange
        //    DateTime testStartDate = new DateTime(2021, 09, 30, 0, 0, 0);
        //    DateTime testEndDate = new DateTime(2021, 09, 1, 0, 0, 0);
        //    // Act
        //    ActionResult<Report> actionResult = controller.GetReportForPeriod(testStartDate, testEndDate).Result;
        //    // Assert
        //    Assert.IsInstanceOfType(actionResult.Result, typeof(BadRequestResult));
        //}
    }
}
