import * as SimpleMDE from "simplemde";
import NameValuePair = JQuery.NameValuePair;


class SiteIndex {
    constructor() {
        $('.site-item').on('click', function(){
            let site_url  = $(this).data('site_url');
            window.open(site_url);
        });
    }
}


class SiteShow {

    constructor() {
        let that = this; 
        $('#add-section').on('click', function (e) {
            e.preventDefault();
            that.createAddSection();
            return true 
        });
        
        $('.section-edit').on('click',function(e: any ){
            e.preventDefault();
            let uuid: string = $(this).data('uuid');
            that.createEditSection(uuid);
            return true;
        });
    }
    createEditSection(uuid :string) {
        let $modal = $('#modal_' + uuid );
    
        let $view_section = $modal.find('.view-section');
        let $content_body = $modal.find(".content-body");
        let $edit_content_section = $modal.find(".edit_content_section");
        let $submit_button = $modal.find('.section-save')
        $view_section.addClass('d-none');
        $edit_content_section.addClass('show');
    
        let s = new SimpleMDE({ element: $content_body[0]});
    
        $submit_button.on("click",function (e){
            e.preventDefault();
    
            $modal.find('.content-section-form').submit();
        });
    }

    createAddSection() {
    
     let $modal = $("#modal_new");
     let $content_body = $modal.find(".content-body");
     let s = new SimpleMDE({ element: $content_body[0]});
     let $submit_button = $modal.find('.new-save')
    
     $submit_button.on("click",function (e){
         e.preventDefault();
    
         $modal.find('.content-section-form').submit();
     })
    }
}

export {SiteShow,SiteIndex}
