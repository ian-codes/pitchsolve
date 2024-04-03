namespace Application.Interfaces;

public interface IPasswordService
{
    public string Hash(string password);
}