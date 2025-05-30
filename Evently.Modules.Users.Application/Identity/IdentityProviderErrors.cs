﻿using Evently.Common.Domain;

namespace Evently.Modules.Users.Application.Identity;

public static class IdentityProviderErrors
{
    public static readonly Error EmailIsNotUnique = Error.Conflict(
        "Identity.EmailIsNotUnique",
        "The specified email is already in use.");
}
