import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Feed } from '../model/Feed';

@Injectable()
export class FeedService {

    http: HttpClient;
    baseUrl: string;
    public article: Feed;
    mediaCategory = ['Actu', 'Science', 'Culture', 'Sport'];

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.http = http;
        this.baseUrl = baseUrl;
    }

    getAllArticles() {
        return this.http.get<Feed[]>(this.baseUrl + 'api/Article/');
    }

    getArticles(cat: number, id: number) {
        return this.http.get<Feed[]>(this.baseUrl + 'api/Article/' + cat + '/' + id);
    }

    //getArticle(cat: number, id: number, inputRand: number) {
    //    return this.http.get<Feed>(this.baseUrl + 'api/Article/GetArticle/' + cat + '/' + id + '/' + inputRand);
    //}
}
