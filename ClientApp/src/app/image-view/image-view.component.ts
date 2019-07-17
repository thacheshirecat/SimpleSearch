import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-image-view',
  templateUrl: './image-view.component.html',
  styleUrls: ['./image-view.component.css']
})
export class ImageViewComponent implements OnInit {
  public images: Images[];

  constructor(private http: HttpClient) {
    this.http.get<Images[]>('api/ImageSearch/GetImages').subscribe(result => {
      this.images = result;
      console.log(result);
    }, error => console.error(error));
  }

  ngOnInit() {
  }

}

interface Images {
  imageName: string;
}
