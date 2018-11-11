import * as FilePond from "filepond";

export class GalleryIndex
{
    constructor() {
        //console.log("we did it!");
       // this.buildUploader();
    }

    // buildUploader() {
    //     const inputElement: any = document.querySelector('#image-uploader');
    //     const pond: any = FilePond.create( inputElement );
    //
    // }



}

export class GalleryShow
{
    constructor() {
        this.buildUploader();
    }

    buildUploader() {
        const inputElement: any = document.querySelector('#image-uploader');

        const pond = FilePond.create(inputElement,
            {
                server: {
                    process: './process',
                    fetch: null,
                    revert: null
                }    
        });
      
    }



}