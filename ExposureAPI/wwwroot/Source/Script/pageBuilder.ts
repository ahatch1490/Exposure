import {SiteShow,SiteIndex} from "./site";
import {GalleryIndex} from "./gallery";


export class pageScriptBuilder {
     
    constructor(){}
    build(name :string) :any {
        return new ObjectStore[name]();
    }

   
}

const  ObjectStore: any  = {SiteIndex ,SiteShow,GalleryIndex};







