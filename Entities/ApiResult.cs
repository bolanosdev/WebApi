namespace WebApi.Entities;

public class ApiResult<T>
{
    public bool Success { get; init; } = false;
    public IEnumerable<ApiError>? Errors { get; init; } = null;
    public T? Data { get; init; } = default;
}
