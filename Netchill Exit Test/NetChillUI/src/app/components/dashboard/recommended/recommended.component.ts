import { movie } from './../../../models/movies';
import { Component, OnInit } from '@angular/core';
import { MoviesService } from 'src/app/services/movies.service';

@Component({
  selector: 'app-recommended',
  templateUrl: './recommended.component.html',
  styleUrls: ['./recommended.component.css']
})
export class RecommendedComponent implements OnInit {

  constructor(private _getMovies:MoviesService) {
  }
  pageNo:number=1;
  total:number=0;
  movies:movie[]=[];
  selectedMovies:movie[]=[];
  loadingImgPath:string="assets/giphy.gif";
  pageLoaded:boolean=false;
  ngOnInit() {
   this._getMovies.getRecommendedMovies()
      .then(res=>{
        this.movies = res as movie[];
        this.total=this.movies.length;
        this.selectedMovies = this.movies.slice(0,6);
        this.pageLoaded=true;
      })
    .catch(err=>{
      if(err.status===0){
        alert('Server not responding.');
      }
      else if(err.status===400 && err.error.Message) alert(err.error.Message);
      else  alert(err.message);
      });
  }
  prevPage(){
    this.pageNo--;
    this.selectedMovies = this.movies.slice(((this.pageNo)-1)*6,6*this.pageNo);
  }
  nextPage(){
    this.pageNo++;
    this.selectedMovies = this.movies.slice(((this.pageNo)-1)*6,6*this.pageNo);
  }

}
