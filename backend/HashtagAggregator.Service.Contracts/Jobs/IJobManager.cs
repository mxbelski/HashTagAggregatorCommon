﻿using System.Threading.Tasks;
using HashtagAggregator.Core.Contracts.Interface.Cqrs.Command;

namespace HashtagAggregator.Service.Contracts.Jobs
{
    public interface IJobManager
    {
        ICommandResult AddJob(IJobTask job);

        ICommandResult DeleteJob(IJobTask job);

        ICommandResult ReconfigureJob(IJobTask job);

        Task<ICommandResult> StartNow(IJobTask job);
    }
}