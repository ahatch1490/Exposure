import $ from "jquery";
import SimpleMDE from "simplemde"; 
 

$(function(){
    
    $('.section-edit').on('click',function(e){
        e.preventDefault();
        
        let uuid = $(this).data('uuid') ;
        console.log(typeof(uuid));
        let $modal = $('#modal_' + uuid );

        let $view_section = $modal.find('.view-section');
        let $content_body = $modal.find(".content-body");
        let $edit_content_section = $modal.find(".edit_content_section");
        
      
        
        $view_section.addClass('d-none');
        $edit_content_section.addClass('show');
        
        let s = new SimpleMDE({ element: $content_body[0]} );
        
    });
    
    $('#section-add').on('click',function(e) {
        let $modal = $('#modal_new');
        let $content_body = $modal.find(".content-body");        
        let s = new SimpleMDE({ element: $content_body[0]} );
    })
    
    
    
    $('.site-item').on('click', function(e){
        let site_url  = $(this).data('site_url');
        
        window.open(site_url);
    });
    
        
});
