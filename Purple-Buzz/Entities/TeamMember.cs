﻿namespace Purple_Buzz.Entities
{
    public class TeamMember : BaseEntity
    {
       
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string PhotoPath { get; set; }
        public string Position { get; set;}
    }
}
