﻿using Devs.Application.Features.Developers.Dtos;
using MediatR;

namespace Devs.Application.Features.Developers.Commands.CreateDeveloper;

public class CreateDeveloperCommand : IRequest<CreatedDeveloperDto>
{
    public string GithubAddress { get; set; }
}