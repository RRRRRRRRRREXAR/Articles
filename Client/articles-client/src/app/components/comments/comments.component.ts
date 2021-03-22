import { Comment } from './../../models/comment';
import { CommentService } from "./../../services/comment.service";
import { Component, Input, OnInit } from "@angular/core";

@Component({
  selector: "app-comments",
  templateUrl: "./comments.component.html",
  styleUrls: ["./comments.component.css"],
})
export class CommentsComponent implements OnInit {
  @Input() articleId: number;
  constructor(private commentService: CommentService) {}
  comments: Comment[];
  ngOnInit() {
    this.commentService
      .GetComments(this.articleId)
      .subscribe((data: Comment[]) => {
        this.comments = data;
      });
  }
}
