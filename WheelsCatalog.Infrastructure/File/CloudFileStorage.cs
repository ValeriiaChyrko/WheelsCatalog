using System.Text.RegularExpressions;
using Firebase.Auth;
using Firebase.Storage;
using Microsoft.Extensions.Configuration;
using WheelsCatalog.Application.Contracts.Infrastructure.File;

namespace WheelsCatalog.Infrastructure.file;

public class CloudFileStorage : ICloudFileStorage
{
    private readonly IConfiguration _configuration;

    public CloudFileStorage(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    private async Task<string> GetFirebaseAuthTokenAsync()
    {
        var apiKey = _configuration["Firebase:ApiKey"];
        var authEmail = _configuration["Firebase:AuthEmail"];
        var authPwd = _configuration["Firebase:AuthPwd"];

        var authProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
        var authResult = await authProvider.SignInWithEmailAndPasswordAsync(authEmail, authPwd);
        return authResult.FirebaseToken;
    }

    public async Task<string> UploadToCloud(FileStream stream, string fileName)
    {
        try
        {
            var authToken = await GetFirebaseAuthTokenAsync();
            var bucket = _configuration["Firebase:Bucket"];

            var storage = new FirebaseStorage(
                bucket,
                new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(authToken),
                    ThrowOnCancel = true
                });

            var uploadTask = storage
                .Child("images")
                .Child(fileName)
                .PutAsync(stream);

            return await uploadTask;
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in UploadToCloud: {ex.Message}");
        }
    }
    
    public async Task DeleteFromCloud(string fileName)
    {
        try
        {
            var authToken = await GetFirebaseAuthTokenAsync();
            var bucket = _configuration["Firebase:Bucket"];

            var storage = new FirebaseStorage(
                bucket,
                new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(authToken),
                    ThrowOnCancel = true
                });

            const string pattern = @"images%2F(.*?)\?alt=";
            var regex = new Regex(pattern);
            var match = regex.Match(fileName);

            if (match.Success)
            {
                string result = match.Groups[1].Value;
                await storage
                    .Child("images")
                    .Child(result)
                    .DeleteAsync();
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in DeleteFromCloud: {ex.Message}");
        }
    }
}
