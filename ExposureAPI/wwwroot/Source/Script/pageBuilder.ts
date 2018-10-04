import {SiteShow,SiteIndex} from "./site";


export class pageScriptBuilder {
     
    constructor(){}
    build(name :string) :any {
        return new ObjectStore[name]();
    }

   
}

const  ObjectStore: any  = {SiteIndex ,SiteShow};







