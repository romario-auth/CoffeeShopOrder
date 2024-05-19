using AutoMapper;
using CoffeeShopOrder.Application.DTO;
using CoffeeShopOrder.Application.Interfaces;
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

        public async Task<UserDTO> Create(UserDTO userDTO, CancellationToken cancellationToken)
        {
            User user = _mapper.Map<User>(userDTO);

            _userRepository.Create(user);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UserDTO>(user);
        }

        public Task<UserDTO> Get(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
