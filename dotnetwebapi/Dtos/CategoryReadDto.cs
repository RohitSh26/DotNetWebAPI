using System;
namespace DotNetWebAPI.Dtos
{
    public class CategoryReadDto
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

    }
}
