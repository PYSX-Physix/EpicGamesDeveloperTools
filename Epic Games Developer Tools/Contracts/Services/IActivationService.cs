namespace Epic_Games_Developer_Tools.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
