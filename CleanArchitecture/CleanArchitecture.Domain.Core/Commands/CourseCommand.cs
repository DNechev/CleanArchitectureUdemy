namespace CleanArchitecture.Domain.Core.Commands
{
    public abstract class CourseCommand : Command
    {
        public string Name { get; protected set; }

        public string CourseDescription { get; protected set; }

        public string CourseImageUrl { get; protected set; }
    }
}
