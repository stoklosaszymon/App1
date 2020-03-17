﻿using GraphQL.Types;
using IOprojekt.Models;
using System;

namespace IOprojekt.GraphQLTypes
{
    public class InputUserType : InputObjectGraphType<User>
    {
        public InputUserType()
        {
            Name = "InputUserType";
            Field(_ => _.Id);
            Field(_ => _.FirstName);
            Field(_ => _.LastName);
            Field(_ => _.Email, nullable: true);
            Field(_ => _.Gender, nullable: true);
            Field(_ => _.Locale, nullable: true);
        }
    }
}