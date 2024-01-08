namespace ProjectX.Data.Models;

public class ApiResponse
{
    public bool Success { get => Error == null; }
    public ApiError Error { get; set; }
    public object Data { get; set; }

    public ApiResponse()
    {
    }

    public ApiResponse(object data)
    {
        Data = data;
    }

    public ApiResponse(object data, ApiError error)
    {
        Data = data;
        Error = error;
    }
}

public class ApiResponse<T>
{
    public bool Success { get => Error == null; }
    public ApiError Error { get; set; }
    public T Data { get; set; }
}

public class ApiError
{
    public int Code { get; set; }
    public string Message { get; set; }

    public ApiError()
    {
    }

    public ApiError(int code, string message)
    {
        Code = code;
        Message = message;
    }
}