import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root",
})
export class CommentService {
  ApiUrl = "https://localhost:44303/api/Article";

  constructor(private http: HttpClient) {}

  GetComments(articleId: number): Observable<Comment[]> {
    return this.http.get<Comment[]>(this.ApiUrl);
  }
}
