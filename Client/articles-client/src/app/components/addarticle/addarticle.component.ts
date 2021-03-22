import { Article } from 'src/app/models/article';
import { Article } from 'src/app/models/article';
import { ArticleService } from "./../../services/article.service";
import { Component, OnInit } from "@angular/core";
import { FormControl, FormGroup } from "@angular/forms";
import { AddArticle } from 'src/app/models/addarticle';

@Component({
  selector: "app-addarticle",
  templateUrl: "./addarticle.component.html",
  styleUrls: ["./addarticle.component.css"],
})
export class AddarticleComponent implements OnInit {
  articleForm = new FormGroup({
    text: new FormControl(""),
  });
  constructor(private articleService: ArticleService) {}

  ngOnInit() {}
  public CreateArticle() {
    const newArticle: AddArticle = {
      text: this.articleForm.get("text").value
    };
    this.articleService.CreateArticle(newArticle).subscribe((data: Article) => {
      console.log(data);
    });
  }
}
