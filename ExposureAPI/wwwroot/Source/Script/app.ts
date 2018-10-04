import 'bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';
import 'underscore';
import '../Styles/site.css';
import '../Styles/app.css';
import 'simplemde';
import 'simplemde/dist/simplemde.min.css';

import {pageScriptBuilder} from "./pageBuilder"


$(function(){
    var name : string = null 
    name = $('#module_pb_seed').val().toString(); 
    if (!name) {return} 
    let builder = new pageScriptBuilder();
    builder.build(name);
}) ;