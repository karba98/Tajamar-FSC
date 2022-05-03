using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AWSBucketMVC.Services
{
    public class ServiceAWSS3
    {
        private String bucketName;
        //cmd aws config
        private IAmazonS3 s3client;

        public ServiceAWSS3 (IAmazonS3 s3client, IConfiguration configuarion)
        {
            this.s3client = s3client;
            this.bucketName = configuarion["AWSS3:bucketName"];
        }
        public async Task<bool> UploadFileAsync(String filename,Stream stream)
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                InputStream = stream,
                Key = filename,
                BucketName = bucketName
            };
            PutObjectResponse response = await this.s3client
                .PutObjectAsync(request);
            if(response.HttpStatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<List<String>> GetS3FilesAsync()
        {
            ListVersionsResponse response = await s3client
                .ListVersionsAsync(this.bucketName);
            return response.Versions.Select(file => file.Key).ToList();
            

        }
        public async Task<bool> DeletFileAsync(String filename)
        {
            
            DeleteObjectResponse response = await s3client
                .DeleteObjectAsync(bucketName,filename);
            if(response.HttpStatusCode == HttpStatusCode.NoContent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<Stream> GetFileAsync(String fileName)
        {
            GetObjectResponse response = await s3client
                .GetObjectAsync(bucketName, fileName);
            if(response.HttpStatusCode == HttpStatusCode.OK)
            {
                return response.ResponseStream;
            }
            else
            {
                return null;
            }
        }
    }
}
