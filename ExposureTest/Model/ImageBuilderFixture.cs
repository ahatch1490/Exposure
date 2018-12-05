using System;
using System.IO;
using Microsoft.Rest.TransientFaultHandling;
using Xunit;
namespace ExposureAPITest
{
    public class ImageBuilderFixture : IDisposable
    {
        private const string IMAGEDESTINATIONPATH = "TestData/Foo/";
        private const string IMAGESOURCEPATH = "TestData/example.png";    
        
        [Fact]
        public void ShouldTakeSourceAndDestinationPath()
        {
            var repo  = new ImageRepo(IMAGESOURCEPATH,IMAGEDESTINATIONPATH, Guid.NewGuid());
            Assert.Equal(IMAGESOURCEPATH, repo.SourcePath);
            Assert.Equal(IMAGEDESTINATIONPATH,repo.DestinationPath);
            
        }

        [Fact]
        public void ShouldGenerateRawImageInPath()
        {
            var id = "9397f68c-0ce8-487f-a987-13c0a5c9cd70"; 
            var repo = new ImageRepo(IMAGESOURCEPATH,IMAGEDESTINATIONPATH, Guid.Parse(id));
          
            repo.Save();

            Assert.True(File.Exists(IMAGEDESTINATIONPATH + $"{id}/raw.png"));
            
        }

        public void Dispose()
        {
            if (! Directory.Exists(IMAGEDESTINATIONPATH))
            {
                return; 
            }

            var info = new DirectoryInfo(IMAGEDESTINATIONPATH);
//            foreach (var file in info.GetFiles())
//            {
//                file.Delete();
//            }
            
            
            
            info.Delete(true);
           
        }
    }

    public class ImageRepo
    {
        public readonly string SourcePath;
        public readonly string DestinationPath;
        public readonly string FullImagePath;
        public readonly Guid ImageId;   
        
        public ImageRepo(string ImageSourcePath, string imageDestinationPath, Guid imageId )
        {
            SourcePath = ImageSourcePath;
            DestinationPath = imageDestinationPath;
            ImageId = imageId; 
            FullImagePath = $"{DestinationPath}/{ImageId.ToString()}"; 
        }

        public void Save()
        {
  
            
            if (!Directory.Exists(FullImagePath))
            {
                Directory.CreateDirectory(FullImagePath);
            }
            
            File.Copy(SourcePath, $"{FullImagePath}/raw.png");
        }
        
       
    }
}