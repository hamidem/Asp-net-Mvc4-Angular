import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { FeedService } from '../shared/service/feed.service';
import { Feed } from '../shared/model/Feed';

@Component({
    selector: 'app-article-list',
    templateUrl: './article-list.component.html',
    styleUrls: ['./article-list.component.css'],
    providers: [FeedService]
})
export class ArticleList implements OnInit {
    http: HttpClient;
    articles: Feed[];
    public loading = false;

    constructor(private route: ActivatedRoute, private service: FeedService) {
    }

    ngOnInit() {
        this.loading = true;
        this.route.params.subscribe(routeParams => {
            this.service.getArticles(routeParams.cat, routeParams.id).subscribe(result => {
                this.setArticle(result);
                //Debug
                //console.error("ArticleList  ", this.articles);
            }, error => console.error(error));
        });
    }

    setArticle(articles: Feed[]) {
        this.articles = articles;
        if (this.articles != null) {
            this.loading = false;
        }
    }
}
