import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root",
})
export class CommentService {
  ApiUrl = "https://localhost:44303/api/Comment";

  constructor(private http: HttpClient) {}

  public GetComments(articleId: number): Observable<Comment[]> {
    return this.http.get<Comment[]>(this.ApiUrl + "/" + articleId);
  }
  public CreateComment(comment: Comment) {
    this.http.post(this.ApiUrl, comment);
  }
}
