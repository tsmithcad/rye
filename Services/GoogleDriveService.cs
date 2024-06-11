// public class GoogleDriveService
// {
//     private readonly DriveService _service;

//     public GoogleDriveService(string apiKey)
//     {
//         var initializer = new BaseClientService.Initializer
//         {
//             ApiKey = apiKey,
//         };

//         _service = new DriveService(initializer);
//     }

//     public async Task<IList<Google.Apis.Drive.v3.Data.File>> GetMp3FilesAsync(string folderId)
//     {
//         var request = _service.Files.List();
//         request.Q = $"'{folderId}' in parents and mimeType='audio/mpeg'";
//         var result = await request.ExecuteAsync();
//         return result.Files;
//     }
// }
