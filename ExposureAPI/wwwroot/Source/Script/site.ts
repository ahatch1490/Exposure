import * as $ from "jquery";
import * as SimpleMDE from "simplemde"; 

 

$(function(){

    let index  = new SiteIndex();
    //let Show = new SiteShow();
   
});

class SiteIndex {
    constructor() {
        $('.site-item').on('click', function(){
            let site_url  = $(this).data('site_url');
            window.open(site_url);
        });
        
    }

}

class Animal {
    name: string;
    constructor(theName: string) { this.name = theName; }
    move(distanceInMeters: number = 0) {
        console.log(`${this.name} moved ${distanceInMeters}m.`);
    }
}

class SiteShow {

    foo: string; 
    add_body: {};
    editable_content: []; 
    constructor() {
        let $modal = $('#modal_new');
        let $content_body = $modal.find(".content-body");
        let s = new SimpleMDE({ element: $content_body[0]});
        let that = this;
        $('.section-edit').on('click',function(e: any ){
            e.preventDefault();

            let uuid = $(this).data('uuid') ;
            let $modal = $('#modal_' + uuid );

            let $view_section = $modal.find('.view-section');
            let $content_body = $modal.find(".content-body");
            let $edit_content_section = $modal.find(".edit_content_section");

            $view_section.addClass('d-none');
            $edit_content_section.addClass('show');

            let s = new SimpleMDE({ element: $content_body[0]});
            //that.editable_content.push({uuid:s}); 
        });
    }

}
