import { ArticleService } from "./../../services/article.service";
import { Component, OnInit } from "@angular/core";
import { Article } from "src/app/models/article";

@Component({
  selector: "app-articles",
  templateUrl: "./articles.component.html",
  styleUrls: ["./articles.component.css"],
})
export class ArticlesComponent implements OnInit {
  constructor(private articleService: ArticleService) {}
  articles: Article[];
  ngOnInit() {
    this.articleService.GetArticles().subscribe((data: Article[]) => {
      this.articles = data;
      console.log(this.articles);
    });
  }
}
