﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopHaXinh.ViewModels.System.Users
{
    public class ForgotPasswordValidator : AbstractValidator<ForgotPasswordViewModel>
    {
        public ForgotPasswordValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email không được để trống");
        }
    }
}
