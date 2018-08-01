import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import {Repo} from './github/repo';

@Injectable()
export class GitHubService {
  GitHubUrl = 'https://api.github.com/'; 

  constructor(private http: HttpClient) { }
  GetRepos(user: string)     {
      //https://api.github.com/users/ahatch1490/repos
    return this.http.get<Repo>(this.GitHubUrl +"users/"+ user + "/repos",{ observe: 'response' });
  }
  GetRepo(id: string) {
    return this.http.get<Repo>(this.GitHubUrl +"repos/" +id,{ observe: 'response' });

  }
}




