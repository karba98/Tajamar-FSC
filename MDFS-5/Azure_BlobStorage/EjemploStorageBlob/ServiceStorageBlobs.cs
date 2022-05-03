using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage;
using System.IO;

namespace EjemploStorageBlob
{
    public class ServiceStorageBlobs
    {
        CloudBlobClient client;
        public ServiceStorageBlobs()
        {
            String keys = ConfigurationSettings.AppSettings["storageaccount"];
            CloudStorageAccount account = CloudStorageAccount.Parse(keys);

            this.client = account.CreateCloudBlobClient();
        }

        public async Task CreateContainer(String containerName)
        {
            CloudBlobContainer container = this.client.GetContainerReference(containerName);
            await container.CreateIfNotExistsAsync();
            await container.SetPermissionsAsync(
                new BlobContainerPermissions
                {
                    PublicAccess=BlobContainerPublicAccessType.Blob
                }
            );
        }
        public List<String> GetContainers()
        {
            List<String> containers = new List<String>();
            foreach(CloudBlobContainer container in this.client.ListContainers())
            {
                containers.Add(container.Name);
            }
            return containers;
        }
        public async Task UploadBlob(String containerName, String filename,String path)
        {
            CloudBlobContainer container = this.client.GetContainerReference(containerName);
            CloudBlockBlob blob = container.GetBlockBlobReference(filename);
            using (var stream = File.OpenRead(path))
            {
                await blob.UploadFromStreamAsync(stream);
            }
        }

        public async Task DeleteBLob(String containerName,String fileName)
        {
            CloudBlobContainer container = this.client.GetContainerReference(containerName);
            CloudBlockBlob blob = container.GetBlockBlobReference(fileName);
            await blob.DeleteAsync();
            
        }
        public List<CloudBlockBlob> GetBlobs(String containername)
        {
            CloudBlobContainer container = this.client.GetContainerReference(containername);
            List<CloudBlockBlob> blobs = new List<CloudBlockBlob>();
            foreach(IListBlobItem blob in container.ListBlobs().ToList())
            {
                blobs.Add((CloudBlockBlob)blob);
            }
            return blobs;
        }

    }
}
