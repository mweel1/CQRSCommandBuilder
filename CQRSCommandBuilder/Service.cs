using System;
namespace CQRSCommandBuilder
{
    public class Service
    {

        string _name;
        string _ns;

        public Service(string name, string ns) {
            this._name = name; this._ns = ns;
        }

        public void Build()
        {
            this.CreateFolder();
            this.CreateDto();
            this.CreateCommand();
        }

        private void CreateFolder()
        {
            Directory.CreateDirectory($"{Environment.CurrentDirectory}/{_name}");
        }


        private string BuildDto()
        {
            return $@"
namespace {_ns}.{_name};

    public class {_name}Dto
    {{

    }}
            ";
        }

        private string BuildCommand()
        {
            return $@";

namespace {_ns }.{_name};

    public class {_name}Command : IRequest<Result<{_name}Dto>>
    {{
                          
    }}

    public class {_name}CommandHandler : IRequestHandler<{_name}Command, Result<{_name}Dto>>
    {{
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        public {_name}CommandHandler (IApplicationDbContext context, ICurrentUserService currentUserService)
        {{
            _context = context;
            _currentUserService = currentUserService;
        }}

        public async Task<Result<{_name}Dto>> Handle({_name}Command request, CancellationToken cancellationToken)
        {{
                               

            return Result<{_name}Dto>.Success(new {_name}Dto() {{ }});
        }}

    }}";
        }

        public  void CreateDto(     )
        {
            File.WriteAllText($"{Environment.CurrentDirectory}/{_name}/{_name}Dto.cs", BuildDto());
        }

        public void CreateCommand()
        {
            File.WriteAllText($"{Environment.CurrentDirectory}/{_name}/{_name}Command.cs", BuildCommand());
        }
    }
}

