import { CommentService } from "./../../services/comment.service";
import { Article } from "./../../models/article";
import { Component, Input, OnInit } from "@angular/core";

@Component({
  selector: "app-article",
  templateUrl: "./article.component.html",
  styleUrls: ["./article.component.css"],
})
export class ArticleComponent implements OnInit {
  @Input() article: Article;
  constructor(private commentService: CommentService) {}

  ngOnInit() {}
}
