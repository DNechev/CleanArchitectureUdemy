﻿namespace CleanArchitecture.Domain.Core.Commands
{
    public class CreateCourseCommand : CourseCommand
    {
        public CreateCourseCommand(string name, string description, string imageUrl)
        {
            this.Name = name;
            this.CourseDescription = description;
            this.CourseImageUrl = imageUrl;
        }
    }
}