using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using LeadManagement.Command.Handlers;
using LeadManagement.Command.Notifications;
using LeadManagement.Data.DbHandlers;
using LeadManagement.Data.Exceptions;
using LeadManagement.Domain;
using LeadManagement.Domain.Enumerations;

using Moq;

using Xunit;

namespace LeadManagement.UnitTests
{
    public class UpdateLeadStatusCommandHandlerUnitTests
    {
        #region Tests

        [Theory]
        [MemberData(nameof(UpdateStatusUnitTestDataGenerator))]
        public async Task UpdateStatusUnitTest(Job job, UpdateLeadStatusCommand command, Type ex)
        {
            var jobDbHandler = new Mock<IJobDbHandler>();
            jobDbHandler.Setup(jh => jh.GetJobById(1)).ReturnsAsync(job);

            var handler = new UpdateLeadStatusCommandHandler(jobDbHandler.Object);

            if (ex == null)
            {
                await handler.Handle(command, CancellationToken.None);

                jobDbHandler.Verify(jh => jh.GetJobById(command.Id), Times.Once);
                jobDbHandler.Verify(jh => jh.UpdateJobAsync(It.IsAny<Job>()), Times.Once);
            }
            else
            {
                await Assert.ThrowsAsync(ex, () => handler.Handle(command, CancellationToken.None));
                jobDbHandler.Verify(jh => jh.UpdateJobAsync(It.IsAny<Job>()), Times.Never);
            }
        }

        #endregion

        #region Data Generator

        public static IEnumerable<object[]> UpdateStatusUnitTestDataGenerator()
        {

            var job = new Job(
                1,
                new Suburb(11, "S1", "1111"),
                new Contact("C1", "987654", "c1@g.c"),
                new Category(21, "Cat1"),
                "Desc1",
                DateTime.Now,
                100,
                Status.New);

            yield return new object[] { job, new UpdateLeadStatusCommand() { Id = 1, Status = 1 }, null };
            yield return new object[] { job, new UpdateLeadStatusCommand() { Id = 2, Status = 1 }, typeof(InvalidJobIdException) };
        }

        #endregion
    }
}
