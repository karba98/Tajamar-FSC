using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Files.Shares;
using MVCCoreStorageFile.Models;

namespace MVCCoreStorageFile.Services
{
    public class ServiceStorageBlob
    {
        private String keys;
        BlobServiceClient client;
        public ServiceStorageBlob(String keys)
        {
            this.keys = keys;
            client = new BlobServiceClient(keys);
            
        }
        public async Task CreateContainseAsync(String containerName)
        {
            var data = client.GetBlobContainerClient(containerName);
            await data.CreateIfNotExistsAsync();
            data.SetAccessPolicy(PublicAccessType.Blob,null,null,default(CancellationToken));
            
        }
        public async Task<List<String>> GetContainers()
        {
            List<String> containers = new List<String>();
            await foreach(var container in client.GetBlobContainersAsync())
            {
                containers.Add(container.Name);
            }
            return containers;
        }
        public async Task<List<Blob>> GetFiles(String containerName)
        {
            List<Blob> blobs = new List<Blob>();
            var container = client.GetBlobContainerClient(containerName);
            await foreach (var blob in container.GetBlobsAsync())
            {
                BlobClient blobclient = container.GetBlobClient(blob.Name);
                blobs.Add(new Blob
                {
                    Nombre=blob.Name,
                    Uri= blobclient.Uri.AbsoluteUri.ToString()
                }
                );
            }
            return blobs;
        }
        public async Task Delete(String filename,String containerName)
        {
            var container = client.GetBlobContainerClient(containerName);
            var blob = container.GetBlobClient(filename);
            await blob.DeleteAsync();
        }
        public async Task Upload(String filename,Stream stream,String containername)
        {

            var container = client.GetBlobContainerClient(containername);
            await container.UploadBlobAsync(filename, stream);
        }
        public async Task DeleteCOntainer(String containername)
        {
            var container = client.GetBlobContainerClient(containername);
            await container.DeleteAsync();
        }
    }
}
