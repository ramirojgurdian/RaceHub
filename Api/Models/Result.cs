namespace Api.Controllers;

public class Result<T>
{

    public bool IsSuccess { get; set; }
    public T? Data { get; set; }
    public string? ErrorMessage { get; set; }

    private Result(bool isSuccess, T? data, string? errorMessage)
    {
        IsSuccess = isSuccess;
        Data = data;
       ErrorMessage = errorMessage; 
    }

    public static Result<T> Success(T data) => new (true, data, null);
    public static Result<T> Failed(string error) => new(false, default, error);

}