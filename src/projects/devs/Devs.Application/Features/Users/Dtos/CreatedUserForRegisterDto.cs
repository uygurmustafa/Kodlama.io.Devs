﻿using Core.Security.JWT;

namespace Devs.Application.Features.Users.Dtos;

public class CreatedUserForRegisterDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public AccessToken AccessToken { get; set; }
}