import { Component, OnInit } from '@angular/core';
import {GitHubService} from '../github-service'
@Component({
  selector: 'app-github',
  templateUrl: './github.component.html',
  styleUrls: ['./github.component.css'],
  providers: [GitHubService]
})
export class GithubComponent implements OnInit {

  constructor(private service: GitHubService ) { }
    spotlightList: ["","moxiworks-dotnet"];  
    spotLights: any[];
    repos: any;  
  ngOnInit() {
    this.service.GetRepos('ahatch1490').subscribe(
      (data: any) => {
        this.repos = data.body;
      }
    )
  }

  forked(isForked: boolean) :string {
    let repo = "assets/github/icons8-repository-24.png" 
    let fork = "assets/github/icons8-code-fork-24.png" 
    console.log(isForked)
    if (isForked ){
      return fork;  
    }
    return repo;  
    
  }

  viewRepo(url) :void {
    console.log(url);
    window.open(url,'_blank');
  }


}
