﻿namespace MovieReminder.Domain;

public class Category
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public List<MovieCategory>? MovieCategories { get; set; }
}
