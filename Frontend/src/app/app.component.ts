import { Component } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/ToPromise';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  private valueUrl = 'api/values';
  values: Trader[];
  constructor(private http: Http){
    this.getValues();
  }
  getValues() {
    this.http.get(this.valueUrl)
    .toPromise()
    .then(response=>this.values = response.json() as Trader[]);
  }
}
class Trader
{
  traderID:string;
  account:string;
}
