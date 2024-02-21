using Firebase.Auth;
using Firebase.Storage;
using Microsoft.Extensions.Configuration;
using WheelsCatalog.Application.contracts.infrastructure.file;

namespace WheelsCatalog.Infrastructure.file;

public class CloudFileStorage : ICloudFileStorage
{
    private IConfiguration Configuration { get; }

    public CloudFileStorage(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public async Task<string> UploadToCloud(FileStream stream, string fileName)
    {
        try
        {
            var apiKey = Configuration["Firebase:ApiKey"];
            var bucket = Configuration["Firebase:Bucket"];
            var authEmail = Configuration["Firebase:AuthEmail"];
            var authPwd = Configuration["Firebase:AuthPwd"];

            var auth = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
            var authResult = await auth.SignInWithEmailAndPasswordAsync(authEmail, authPwd);

            var storage = new FirebaseStorage(
                bucket,
                new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(authResult.FirebaseToken),
                    ThrowOnCancel = true
                });

            var cancellation = new CancellationTokenSource();
            var task = storage
                .Child("images")
                .Child(fileName)
                .PutAsync(stream, cancellation.Token);

            return await task;
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in UploadToCloud: {ex.Message}");
        }
    }
}