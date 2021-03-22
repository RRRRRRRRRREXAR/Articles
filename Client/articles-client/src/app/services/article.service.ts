import { AddArticle } from './../models/addarticle';
import { Article } from "./../models/article";
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root",
})
export class ArticleService {
  ApiUrl = "https://localhost:44303/api/Article";
  constructor(private http: HttpClient) {}
  public GetArticles(): Observable<Article[]> {
    return this.http.get<Article[]>(this.ApiUrl);
  }
  public CreateArticle(article: AddArticle) {
    return this.http.post(this.ApiUrl, article);
  }
}
