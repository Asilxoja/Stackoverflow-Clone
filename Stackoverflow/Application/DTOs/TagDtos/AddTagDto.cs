namespace Application.DTOs.TagDtos;

public class AddTagDto
{
    public string Name { get; set; } = string.Empty!;

    public static implicit operator Tag(AddTagDto dto) => new()
    {
        Name = dto.Name,
    };
}
