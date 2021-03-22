import { Comment } from "./../../models/comment";
import { CommentService } from "./../../services/comment.service";
import { Component, Input, OnInit } from "@angular/core";
import { AddComment } from "src/app/models/addcomment";
import { FormGroup, FormControl } from "@angular/forms";

@Component({
  selector: "app-addcomment",
  templateUrl: "./addcomment.component.html",
  styleUrls: ["./addcomment.component.css"],
})
export class AddcommentComponent implements OnInit {
  @Input() isVisible: boolean;
  @Input() articleId: number;

  commentForm = new FormGroup({
    userName: new FormControl(''),
    text: new FormControl(''),
  });
  constructor(private commentService: CommentService) {}
  ngOnInit() {}
  public AddComment() {
    const newComment: AddComment = {
      UserName: this.commentForm.get("userName").value,
      Text: this.commentForm.get("text").value,
      ArticleId: this.articleId,
    };
    this.commentService.CreateComment(newComment).subscribe((data: Comment) => {
      console.log(data);
    });
  }
  public Reply() {
    this.isVisible = !this.isVisible;
  }
}
