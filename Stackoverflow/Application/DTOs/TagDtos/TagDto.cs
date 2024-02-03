namespace Application.DTOs.TagDtos;

public class TagDto : BaseDto
{
    public string Name { get; set; } = string.Empty!;

    public static implicit operator Tag(TagDto dto) => new()
    {
        Name = dto.Name,
        Id = dto.Id
    };
}
