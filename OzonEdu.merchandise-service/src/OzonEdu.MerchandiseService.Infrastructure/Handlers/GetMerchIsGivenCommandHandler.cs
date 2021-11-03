using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OzonEdu.MerchandiseService.Domain.AggregationModels.EmployeeAggregate;
using OzonEdu.MerchandiseService.Infrastructure.Commands.GetMerchIsIssued;


namespace OzonEdu.MerchandiseService.Infrastructure.Handlers
{
    public class GetMerchIsGivenCommandHandler : IRequestHandler<GetMerchIsIssuedCommand>
    {
        private IEmployeeRepository _employeeRepository;

        public GetMerchIsGivenCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Unit> Handle(GetMerchIsIssuedCommand request, CancellationToken cancellationToken)
        {
            return Unit.Value;
        }
    }
}