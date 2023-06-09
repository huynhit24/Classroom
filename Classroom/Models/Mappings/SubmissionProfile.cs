﻿using AutoMapper;
using Classroom.Application.Common.SignalR;
using Classroom.Data;
using Classroom.Models.Catalog.Submissions;

namespace Classroom.Models.Mappings
{
    public class SubmissionProfile : Profile
    {
        public SubmissionProfile()
        {
            CreateMap<Submission, SubmissionViewModel>();
            CreateMap<SubmissionViewModel, SubmissionUpdateRequest>();
        }
    }
}
