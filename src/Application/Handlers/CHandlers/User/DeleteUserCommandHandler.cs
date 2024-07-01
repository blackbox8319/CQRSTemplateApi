using Application.Commands.User;
using Application.Common.Interfaces.User;
using Application.Response;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.CHandlers.User
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, GenericPairResponse>
    {
        private readonly IUserCommand _command;
        private readonly IMapper _mapper;

        public DeleteUserCommandHandler(IUserCommand command, IMapper mapper)
        {
            _command = command;
            _mapper = mapper;
        }

        public async Task<GenericPairResponse> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var result = await _command.DeleteUserAsync(request);
            return _mapper.Map<GenericPair, GenericPairResponse>(result);
        }
    }
}
