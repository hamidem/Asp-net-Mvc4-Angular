import { Component, OnInit } from '@angular/core';
import { FeedService } from '../shared/service/feed.service';
import { Feed } from '../shared/model/Feed';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css'],
    providers: [FeedService]
})
export class HomeComponent implements OnInit {
    articles: Feed[];
    public loading = false;

    constructor(private service: FeedService) {
    }

    ngOnInit() {
        this.loading = true;
        this.service.getAllArticles().subscribe(result => {
            this.setArticle(result);
            //Debug
            //console.error("Articles  ", this.articles);
        }, error => console.error(error));
    }

    setArticle(articles: Feed[]) {
        this.articles = articles;
        if (this.articles != null) {
            this.loading = false;
        }
    }
}
