using Application.Core;
using Application.Logs;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Profiles
{
    public class ListLogs
    {
        public class Query : IRequest<Result<List<LogDto>>>
        {
            public string UserName { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<List<LogDto>>>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<Result<List<LogDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var logs = await _context.Logs
                    .Where(x => x.AppUser.UserName == request.UserName)
                    .OrderBy(x => x.Date)
                    .ProjectTo<LogDto>(_mapper.ConfigurationProvider)
                    .ToListAsync();

                return Result<List<LogDto>>.Success(logs);
            }
        }
    }
}
