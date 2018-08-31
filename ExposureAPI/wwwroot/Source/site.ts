import $ from "jquery";

$( function () {
    $('.lnk-html-content').on('click', function (e: any) {
        e.stopPropagation();
        e.preventDefault();
        console.log("clicked");
    }) 
    
} )