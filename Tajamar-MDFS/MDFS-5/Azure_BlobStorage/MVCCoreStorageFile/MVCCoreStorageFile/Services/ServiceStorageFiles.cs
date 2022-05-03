using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Azure.Storage.Files.Shares;
using Azure.Storage.Files.Shares.Models;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.File;

namespace MVCCoreStorageFile.Services
{
    public class ServiceStorageFiles
    {
        String keys;
        private ShareClient client;
        private ShareDirectoryClient root;
        public ServiceStorageFiles(String keys)
        {
            this.keys = keys;
            //la quiero sacar de appsetting json
            client = new ShareClient(keys, "ejemplo");
            root = this.client.GetRootDirectoryClient();
        }
        public async Task<List<String>> GetFilesAsync()
        {
            List<String> files = new List<String>();
            await foreach(var file in this.root.GetFilesAndDirectoriesAsync())
            {
                files.Add(file.Name);
            }
            return files;
        }
        public async Task UploadFile(String filename, Stream stream)
        {
            ShareFileClient fileclient = this.root.GetFileClient(filename);
            await fileclient.CreateAsync(stream.Length);
            await fileclient.UploadAsync(stream);

        }
        public async Task DeleteFile(String filename)
        {
            ShareFileClient fileclient = this.root.GetFileClient(filename);
            await fileclient.DeleteAsync();
        }
        public async Task<String> GetFileContentAsync(String filename)
        {
            ShareFileClient fileclient = root.GetFileClient(filename);
            var data = await fileclient.DownloadAsync();
            Stream stream = data.Value.Content;
            StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }
        
    }
}
