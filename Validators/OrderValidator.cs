using FluentValidation;
using MachsystemsTask.Entity;
using System.Collections.Generic;

namespace MachsystemsTask.Validators
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator(HashSet<int> validCustomerIds)
        {
            RuleFor(order => order.CustomerId)
                .Must(customerId => validCustomerIds.Contains(customerId))
                .WithMessage("CustomerId does not exist.");

            RuleFor(order => order.Created)
                .LessThanOrEqualTo(System.DateTime.Now)
                .WithMessage("Order date cannot be in the future.");
        }
    }
}
