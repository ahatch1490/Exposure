import * as FilePond from "filepond"

export class GalleryIndex
{
    constructor() { 
        console.log("we did it!");
        this.buildUploader();
    }
    
    buildUploader() {
        const inputElement: any = document.querySelector('#image-uploader');
        const pond: any = FilePond.create( inputElement );
        
    }
    
        
    
}