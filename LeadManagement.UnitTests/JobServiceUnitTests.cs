using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeadManagement.Application;
using LeadManagement.Data.DbHandlers;
using LeadManagement.Domain;
using LeadManagement.Domain.Enumerations;
using Moq;
using Xunit;

namespace LeadManagement.UnitTests
{
    public class JobServiceUnitTests
    {
        #region Tests

        [Theory]
        [MemberData(nameof(GetAllAccountsUnitTestsDataGenerator))]
        public async Task GetAllAccountsUnitTests(IEnumerable<Job> list)
        {
            var mockAccountDbHandler = new Mock<IJobDbHandler>();
            mockAccountDbHandler.Setup(h => h.GetAllJobs()).ReturnsAsync(list);

            var userService = new JobServices(mockAccountDbHandler.Object);

            var users = await userService.GetJobs();

            Assert.Equal(list.Count(), users.Count());
        }

        #endregion

        #region Data Generator

        public static IEnumerable<object[]> GetAllAccountsUnitTestsDataGenerator()
        {
            yield return new object[]
                             {
                                 new List<Job>()
                                     {
                                         new Job(
                                             1,
                                             new Suburb(11, "S1", "1111"),
                                             new Contact("C1", "987654", "c1@g.c"),
                                             new Category(21, "Cat1"),
                                             "Desc1",
                                             DateTime.Now,
                                             100,
                                             Status.New),
                                         new Job(
                                             2,
                                             new Suburb(12, "S2", "1111"),
                                             new Contact("C2", "987655", "c2@g.c"),
                                             new Category(22, "Cat2"),
                                             "Desc2",
                                             DateTime.Now,
                                             110,
                                             Status.Accepted),
                                         new Job(
                                             3,
                                             new Suburb(12, "S2", "1111"),
                                             new Contact("C3", "987656", "c3@g.c"),
                                             new Category(21, "Cat1"),
                                             "Desc3",
                                             DateTime.Now,
                                             120,
                                             Status.Declined)
                                     }
                             };

            yield return new object[] { Enumerable.Empty<Job>() };
        }

        #endregion
    }
}
