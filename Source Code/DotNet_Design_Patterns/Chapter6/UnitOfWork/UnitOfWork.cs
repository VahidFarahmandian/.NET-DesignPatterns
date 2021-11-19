using DotNet_Design_Patterns.Chapter6.Repository;

namespace DotNet_Design_Patterns.Chapter6.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();
        public IRepository<User, int> UserRepository { get; }
        public IRepository<BankAccount, int> BankAccountRepository { get; }

    }
    public class UnitOfWork : IUnitOfWork
    {
        private SampleDbContext _context = new();
        private IRepository<User, int> _userRepository;
        private IRepository<BankAccount, int> _bankAccountRepository;

        public IRepository<User, int> UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new GenericRepository<User, int>(_context);
                return _userRepository;
            }
        }
        public IRepository<BankAccount, int> BankAccountRepository
        {
            get
            {
                if (_bankAccountRepository == null)
                    _bankAccountRepository = new GenericRepository<BankAccount, int>(_context);
                return _bankAccountRepository;
            }
        }
        public void Commit() => _context.SaveChanges();
    }
}
