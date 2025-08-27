using Domain;
using MediatR;
using Persistence;


namespace Application.Activities.Commands
{
    //public class CreateActivity
    //{
    //    public class Command : IRequest<string> 
    //    {
    //        public required Activity Activity { get; set; }
    //    }
    //    public class Handler(AppDbContext context) : IRequestHandler<Command, string> 
    //    {
    //        public async Task<string> Handle(Command request, CancellationToken cancellationToken)
    //        {
    //            context.Activities.Add(request.Activity);
    //            await context.SaveChangesAsync(cancellationToken);
    //            return request.Activity.Id;
    //        }
    //    }
    //}

    public class CreateActivity
    {
        public class Command : IRequest<string>
        {
            public string? Id { get; set; }
            public string? Title { get; set; }
            public string? Description { get; set; }
            public string? Category { get; set; }
            public DateTime Date { get; set; }
            public string? City { get; set; }
            public string? Venue { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }

        public class Handler(AppDbContext context) : IRequestHandler<Command, string>
        {
            public async Task<string> Handle(Command request, CancellationToken cancellationToken)
            {
                var activity = new Activity
                {
                    Id = request.Id ?? Guid.NewGuid().ToString(),
                    Title = request.Title ?? string.Empty,
                    Description = request.Description ?? string.Empty,
                    Category = request.Category ?? string.Empty,
                    Date = request.Date,
                    City = request.City ?? string.Empty,
                    Venue = request.Venue ?? string.Empty,
                    Latitude = request.Latitude,
                    Longitude = request.Longitude,
                    IsCancelled = false
                };

                context.Activities.Add(activity);
                await context.SaveChangesAsync(cancellationToken);
                return activity.Id;
            }
        }
    }


}
