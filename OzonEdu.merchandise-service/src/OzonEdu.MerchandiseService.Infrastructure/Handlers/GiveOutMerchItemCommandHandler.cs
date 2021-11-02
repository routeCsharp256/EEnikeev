using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OzonEdu.MerchandiseService.Domain.AggregationModels.EmployeeAggregate;
using OzonEdu.MerchandiseService.Domain.Factory;
using OzonEdu.MerchandiseService.Infrastructure.Commands.GiveOutMerchItem;

namespace OzonEdu.MerchandiseService.Infrastructure.Handlers
{
    public class GiveOutMerchItemCommandHandler : IRequestHandler<GiveOutMerchItemCommand>
    {
        private IEmployeeRepository _employeeRepository;

        public GiveOutMerchItemCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        
        public async Task<Unit> Handle(GiveOutMerchItemCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.FindByIdAsync(request.EmployeeId, cancellationToken);
            
            // если такого сотрудника еще нет, значит надо его создать
            if (employee == null)
            {
                employee = EmployeeFactory.CreateEmployee();
            }
            

            //bool inStock = false;
            
            // если мерч не выдавался, то делаем запрос на выдачу
            //if (!employee.AlreadyIssued(request.MerchId))
            {
                 //inStock = true;
            }
            
            // если мерч есть на складе, то выдаем сотруднику, иначе помещаем в список на ожидание
            //if (inStock) employee.Give(request.MerchId);
            //else employee.AddInQueue(request.MerchId);

            /*employee.GiveOutItems(request.Quantity);
            
            await _merchItemRepository.UpdateAsync(employee, cancellationToken);
            
            await _merchItemRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);*/

            return Unit.Value;

        }
    }
}