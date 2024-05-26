using AutoMapper;
using CoffeeShopOrder.Application.Interfaces;
using CoffeeShopOrder.Application.Models.DTO;
using CoffeeShopOrder.Application.Models.Requests;
using CoffeeShopOrder.Application.Models.Responses;
using CoffeeShopOrder.Domain.Entities;
using CoffeeShopOrder.Domain.Interfaces;

namespace CoffeeShopOrder.Application.Services
{
    public class UserService : IUserService
    {
        protected readonly IUserRepository _userRepository;
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<GetUserResponse> Get(Guid id, CancellationToken cancellationToken)
        {
            User user = await _userRepository.Get(id, cancellationToken);

            return _mapper.Map<GetUserResponse>(user);
        }

        public async Task<UserDTO> Create(UserCreateRequest userCreateRequest, CancellationToken cancellationToken)
        {
            User user = _mapper.Map<User>(userCreateRequest);

            _userRepository.Create(user);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UserDTO>(user);
        }

        public async Task<List<GetUserResponse>> List(CancellationToken cancellationToken)
        {
            List<User> user = await _userRepository.GetAll(cancellationToken);

            return _mapper.Map<List<GetUserResponse>>(user);
        }
    }
}
