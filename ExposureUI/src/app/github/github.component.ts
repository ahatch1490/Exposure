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
   spotLights: any[];
  ngOnInit() {
    this.service.GetRepo('ahatch1490/moxiworks-dotnet').subscribe(
      (data: any) => {
        this.spotLights = []
        console.log(data.body);
        this.spotLights[0] = data.body;
      }
    )
  }

}
